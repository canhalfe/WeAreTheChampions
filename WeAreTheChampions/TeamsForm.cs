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
            ListColors();
            cboFirstColor.SelectedIndex = cboSecondColor.SelectedIndex = -1;
        }

        private void ListColors()
        {
            cboFirstColor.DataSource = db.Colors.ToList();
            cboSecondColor.DataSource = db.Colors.ToList();
        }

        protected virtual void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList().Where(x => !x.TeamName.Contains("Closed")).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "")
            {
                MessageBox.Show("Please enter a team name!");
            }
            var color1 = (Model.Color)cboFirstColor.SelectedItem;
            var color2 = (Model.Color)cboSecondColor.SelectedItem;
            if (color1 == null || color2 == null)
            {
                MessageBox.Show("Please choose colors.");
                return;
            }
            List<Model.Color> colors = new List<Model.Color>();
            colors.Add(color1);
            colors.Add(color2);

            var teamName = txtTeamName.Text.UppercaseFirst();
            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
                if (db.Teams.ToList().Any(x => x.TeamName.ToLower() == teamName.ToLower().Replace(" ","")
                        && selectedTeam.TeamName.ToLower() != teamName.ToLower().Replace(" ", "")))
                {
                    MessageBox.Show("There is already a team with this team name!");
                    return;
                }
                selectedTeam.TeamName = teamName;
                selectedTeam.TeamColors = colors;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            if (db.Teams.ToList().Any(x => x.TeamName.ToLower() == teamName.ToLower().Replace(" ", "")))
            {
                MessageBox.Show("There is already a team with this team name!");
                return;
            }
            db.Teams.Add(new Team() { TeamName = teamName, TeamColors = colors });
            db.SaveChanges();
            ListTeams();
            ResetForm();
            WhenMakeChange(EventArgs.Empty);
        }

        private void ResetForm()
        {
            btnEdit.Text = "🖋 Edit";
            btnEdit.BackColor = System.Drawing.Color.Black;
            lstTeams.Enabled = true;
            btnAdd.Text = "+ Add";
            txtTeamName.Clear();
            lblFirstColor.BackColor = lblSecondColor.BackColor = System.Drawing.Color.Transparent;
            cboSecondColor.SelectedIndex = cboFirstColor.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
                return;

            var selectedTeam = (Team)lstTeams.SelectedItem;
            if (selectedTeam.TeamName.Contains("(Closed)"))
            {
                MessageBox.Show("Selected team is already closed");
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
            if (btnEdit.Text == "Cancel")
            {
                ResetForm();
                return;
            }
            btnEdit.Text = "Cancel";
            btnEdit.BackColor = System.Drawing.Color.Navy;
            if (lstTeams.SelectedIndex < 0) return;
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            //List<Model.Color> colors = selectedTeam.TeamColors.ToList();
          
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;

            #region Edite Basılınca Renk isimleri cbo'lara gelsin
            var renkler = selectedTeam.TeamColors.ToList();
            if (renkler.Count == 1)
            {
                cboFirstColor.SelectedItem = renkler[0];
            }
            else if (renkler.Count == 2)
            {
                cboFirstColor.SelectedItem = renkler[0];
                cboSecondColor.SelectedItem = renkler[1];
            }
            #endregion
        }

        private void cboFirstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFirstColor.SelectedItem == null)
                cboSecondColor.Enabled = false;
            else
                cboSecondColor.Enabled = true;
            
            if (cboFirstColor.SelectedIndex == -1)
            {
                lblFirstColor.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            var selectedColor = (Model.Color)cboFirstColor.SelectedItem;
            lblFirstColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void cboSecondColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSecondColor.SelectedIndex == -1)
            {
                lblSecondColor.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            var selectedColor = (Model.Color)cboSecondColor.SelectedItem;
            lblSecondColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team = (Team)lstTeams.SelectedItem;
            List<Model.Color> renkler = team.TeamColors.ToList();
            if (renkler.Count == 0)
            {
                lblBg.BackColor = System.Drawing.Color.Transparent;
                lblBg2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (renkler.Count == 1)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.FromArgb(renkler[1].Red, renkler[1].Green, renkler[1].Blue);
            }
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            var team = (Team)lstTeams.SelectedItem;
            var teamId = team.Id;
            var frmPlayerform = new PlayerForm(db,teamId);
            frmPlayerform.ShowDialog();
        }
    }
}
