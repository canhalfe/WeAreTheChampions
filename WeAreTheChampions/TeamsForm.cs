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

        private void TeamColorShow()
        {
            var team = (Team)lstTeams.SelectedItem;
            List<Model.Color> renkler = team.TeamColors.ToList();

            if (renkler.Count == 0)
            {
                lblBg.BackColor = lblBg2.BackColor = lblColorFirst.BackColor = lblColorSecond.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            if (renkler.Count == 1)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblColorFirst.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                return;
            }
            if (renkler.Count == 2)
            {
                lblColorFirst.BackColor = lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblColorSecond.BackColor = lblBg2.BackColor = System.Drawing.Color.FromArgb(renkler[1].Red, renkler[1].Green, renkler[1].Blue);
            }
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
            var renk = CreateColor(lblColorFirst);
            var renk2 = CreateColor(lblColorSecond);

            if (btnAdd.Text == "💾 Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;

                List<Model.Color> renklerEdit = new List<Model.Color>();
                renklerEdit.Add(renk);
                renklerEdit.Add(renk2);
                selectedTeam.TeamColors = renklerEdit;
                selectedTeam.TeamName = txtTeamName.Text;
                db.SaveChanges();
                ListTeams();
                ResetForm();
                WhenMakeChange(EventArgs.Empty);
                return;
            }
            List<Model.Color> renkler = new List<Model.Color>();
            renkler.Add(renk);
            renkler.Add(renk2);
            db.Teams.Add(new Team { TeamName = txtTeamName.Text, TeamColors = renkler });
            db.SaveChanges();
            ListTeams();
            WhenMakeChange(EventArgs.Empty);
        }

        private Model.Color CreateColor(Label lbl)
        {
            System.Drawing.Color firstlblcolor = lbl.BackColor;
            byte r = firstlblcolor.R;
            byte g = firstlblcolor.G;
            byte b = firstlblcolor.B;
            var renk = new Model.Color() { Red = r, Green = g, Blue = b };
            return renk;
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
            if (selectedTeam.Players != null || selectedTeam.Team1Matches != null || selectedTeam.Team2Matches != null)
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
            if (lstTeams.SelectedIndex < 0)
            {
                return;
            }
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            btnAdd.Text = "💾 Save";
            txtTeamName.Text = selectedTeam.TeamName;
        }

        private void lblColorFirst_Click(object sender, EventArgs e)
        {
            if (colorDialogFirst.ShowDialog() == DialogResult.OK)
            {
                lblColorFirst.BackColor = colorDialogFirst.Color;
            }
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamColorShow();
        }

        private void lblColorSecond_Click(object sender, EventArgs e)
        {
            if (colorDialogSecond.ShowDialog() == DialogResult.OK)
            {
                lblColorSecond.BackColor = colorDialogSecond.Color;
            }
        }
    }
}
