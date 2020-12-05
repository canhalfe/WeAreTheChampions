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

    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public Form1()
        {
            InitializeComponent();
            ResultControl();
            ListMatches();
        }

        private void ResultControl()
        {
            var matches = db.Matches.ToList();
            foreach (var item in matches)
            {
                if (item.Score2 > item.Score1)
                    item.Result = Result.Team2;
                
                else if (item.Score1 > item.Score2)
                    item.Result = Result.Team1;
                
                else if (item.Score1 == item.Score2 && DateTime.Now > item.MatchTime)
                    item.Result = Result.Draw;
                
                else
                    item.Result = null;
                
                db.SaveChanges();
            }
        }

        private void ListMatches()
        {
            IEnumerable<dynamic> maclar = Anonim<dynamic>();

            var matches = maclar.ToList();
            if (chkHideCompleted.Checked == true)
            {
                matches = maclar.Where(x => x.Result == null)
                .ToList();
            }
            dgvMatches.DataSource = matches;
        }

        private IEnumerable<T> Anonim<T>()  //var matches kısmını 2 kez yazmamak için böyle bir generic method oluşturduk.
        {
            var matches = db.Matches.ToList().OrderByDescending(x => x.MatchTime).ToList()
                .Select(
                x => new
                {
                    MatchNo = x.Id,
                    HomeTeam = x.Team1.TeamName,
                    AwayTeam = x.Team2.TeamName,
                    Tarih = x.MatchTime?.ToShortDateString(),
                    Saat = x.MatchTime?.ToShortTimeString(),
                    Score = x.Score1 + "-" + x.Score2,
                    Result = x.Result
                });
            return (IEnumerable<T>)matches;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int selectedIdMainForm = 0;
            var frmAddMatchForm = new MatchDetailsForm(db,selectedIdMainForm);
            frmAddMatchForm.HasBeenChanged += FrmAddMatchForm_HasBeenChanged;
            frmAddMatchForm.ShowDialog();
        }

        private void FrmAddMatchForm_HasBeenChanged(object sender, EventArgs e)
        {
            ResultControl();
            ListMatches();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match selectedMatch = db.Matches.ToList().FirstOrDefault(x => x.Id == selectedId);
            db.Matches.Remove(selectedMatch);
            db.SaveChanges();
            ListMatches();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedIdMainForm = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            var frmAddMatchForm = new MatchDetailsForm(db,selectedIdMainForm);
            frmAddMatchForm.HasBeenChanged += FrmAddMatchForm_HasBeenChanged;
            frmAddMatchForm.ShowDialog();
        }

        private void chkHideCompleted_CheckedChanged(object sender, EventArgs e)
        {
            ListMatches();
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            var frmTeamsform = new frmTeamsForm(db);
            frmTeamsform.HasBeenChanged += FrmTeamsform_HasBeenChanged;
            frmTeamsform.ShowDialog();
            
        }

        private void FrmTeamsform_HasBeenChanged(object sender, EventArgs e)
        {
            ResultControl();
            ListMatches();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teamId = 0;
            var frmPlayersForm = new PlayerForm(db,teamId);
            frmPlayersForm.ShowDialog();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcolorsForm = new ColorsForm(db);
            frmcolorsForm.ShowDialog();
        }
    }
}
