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
    public partial class frmTeamsForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public event EventHandler HasBeenChanged;
        public frmTeamsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListTeams();
        }

        protected virtual void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
                selectedTeam.TeamName = txtTeamName.Text;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            
            db.Teams.Add(new Team() { TeamName = txtTeamName.Text});
            db.SaveChanges();
            ListTeams();
            ResetForm();
            WhenMakeChange(EventArgs.Empty);
        }

        private void ResetForm()
        {
            lstTeams.Enabled = true;
            btnAdd.Text = "+ Add";
            txtTeamName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
                return;

            var selectedTeam = (Team)lstTeams.SelectedItem;
            if (selectedTeam.TeamName.Contains("(Closed)"))
            {
                MessageBox.Show("Selected Team already closed");
                return;
            }
            if (selectedTeam.Players.Count != 0 || selectedTeam.Team1Matches != null || selectedTeam.Team2Matches != null)
            {
                selectedTeam.TeamName = selectedTeam.TeamName + "(Closed)";
                if (selectedTeam.Players.Count != 0)
                {
                    var players = selectedTeam.Players.ToList();
                    players.ForEach(x => x.TeamId = null);
                }
                db.SaveChanges();
                WhenMakeChange(EventArgs.Empty);
                ListTeams();
                return;
            }
            db.Teams.Remove(selectedTeam);
            db.SaveChanges();
            WhenMakeChange(EventArgs.Empty);
            ListTeams();
            txtTeamName.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0) return;
            //Edit Mode Activated
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            List<Model.Color> colors = selectedTeam.TeamColors.ToList();
          
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;
        }
        
        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
