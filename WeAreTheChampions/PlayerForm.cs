using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Model;

namespace WeAreTheChampions
{
    public partial class PlayerForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        private readonly int teamId;
        public PlayerForm(WeAreTheChampionsContext db, int teamId)
        {
            this.teamId = teamId;
            this.db = db;
            InitializeComponent();
            ListPlayersTeam();
            ListTeams();
        }

        private void ListPlayersTeam()
        {
            var teams = db.Teams.ToList().Where(x => !x.TeamName.Contains("(Closed)")).ToList();
            teams.Insert(0, new Team { TeamName = "Select Team" });
            teams.Add(new Team { TeamName = "Free Agency" });
            cboPlayersTeam.DataSource = teams;
        }

        private void ListTeams()
        {
            var teams = db.Teams.ToList().Where(x => !x.TeamName.Contains("(Closed)")).ToList();
            teams.Insert(0, new Team { TeamName = "All" });
            teams.Add(new Team { TeamName = "Free Agency" });
            cboTeams.DataSource = teams;
        }

        private void ListPlayers()
        {
            if (teamId != 0)
            {
                var team = db.Teams.ToList().Find(x => x.Id == teamId);
            }
            var selectedTeam = (Team)cboTeams.SelectedItem;
            var selectedTeamId = selectedTeam.Id;
            if (cboTeams.SelectedIndex == 0)
            {
                lstPlayers.DataSource = db.Players.ToList();
            }
            else if (cboTeams.SelectedIndex == cboTeams.Items.Count - 1)
            {
                var selectedTeamPlayers = db.Players.ToList().Where(x => x.TeamId == null);
                lstPlayers.DataSource = selectedTeamPlayers.ToList();
            }
            else
            {
                var selectedTeamPlayers = db.Players.ToList().Where(x => x.TeamId == selectedTeamId);
                lstPlayers.DataSource = selectedTeamPlayers.ToList();
            }
        }

        private void cboTeams_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListPlayers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var team = (Team)cboPlayersTeam.SelectedItem;
            if (btnAdd.Text == "💾 Save")
            {
                var selectedplayer = (Player)lstPlayers.SelectedItem;
                selectedplayer.PlayerName = txtPlayerName.Text;
                selectedplayer.Team = cboPlayersTeam.SelectedIndex == cboPlayersTeam.Items.Count - 1 ? null : team;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                return;
            }
            string playerName = txtPlayerName.Text.Trim();
            if (cboPlayersTeam.SelectedIndex == 0 || playerName == "")
            {
                return;
            }
            
            db.Players.Add(new Player()
            {
                PlayerName = playerName,
                Team = cboPlayersTeam.SelectedIndex == cboPlayersTeam.Items.Count - 1 ? null : team
            });
            db.SaveChanges();
            ListPlayers();
            ResetForm();
        }

        private void ResetForm()
        {
            lstPlayers.Enabled = true;
            btnAdd.Text = "+ Add";
            txtPlayerName.Clear();
            cboPlayersTeam.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0)
            {
                return;
            }
            var selectedPlayer = (Player)lstPlayers.SelectedItem;
            db.Players.Remove(selectedPlayer);
            db.SaveChanges();
            ListPlayers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0)
            {
                return;
            }
            lstPlayers.Enabled = false;
            var selectedplayer = (Player)lstPlayers.SelectedItem;
            btnAdd.Text = "💾 Save";
            txtPlayerName.Text = selectedplayer.PlayerName;
            cboPlayersTeam.SelectedItem = selectedplayer.Team;
        }
    }
}
