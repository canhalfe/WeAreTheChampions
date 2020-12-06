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
    public partial class ColorsForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public ColorsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListColors();
        }

        private void ListColors()
        {
            lstColors.DataSource = db.Colors.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var colorName = txtColorName.Text.UppercaseFirst().Trim();
            if (colorName == "")
            {
                MessageBox.Show("Please enter a color name");
                return;
            }
            if (btnAdd.Text == "💾 Save")
            {
                var selectedColor = (Model.Color)lstColors.SelectedItem;
                selectedColor.ColorName = txtColorName.Text;
                if (db.Colors.Any(x => x.ColorName == selectedColor.ColorName) 
                    && selectedColor.ColorName != txtColorName.Text.UppercaseFirst())
                {
                    MessageBox.Show("Color name is already exist. Please enter a different color name.");
                    return;
                };
                selectedColor.ColorName = txtColorName.Text.UppercaseFirst();
                selectedColor.Red = Convert.ToByte(lblRed.Text);
                selectedColor.Green = Convert.ToByte(lblGreen.Text);
                selectedColor.Blue = Convert.ToByte(lblBlue.Text);
                db.SaveChanges();
                ListColors();
                ResetForm();
                return;
            }
            var color = new Model.Color 
            { 
                ColorName = txtColorName.Text.UppercaseFirst(), 
                Red = Convert.ToByte(lblRed.Text), 
                Green = Convert.ToByte(lblGreen.Text), 
                Blue = Convert.ToByte(lblBlue.Text) 
            };
            if (db.Colors.Any(x => x.ColorName == color.ColorName))
            {
                MessageBox.Show("Color name is already exist. Please enter a different color name.");
                return;
            } ;
            db.Colors.Add(color);
            db.SaveChanges();
            ListColors();
            ResetForm();
        }

        private void ResetForm()
        {
            lstColors.Enabled = true;
            btnAdd.Text = "+ Add Color";
            txtColorName.Clear();
            lblRed.Text = lblGreen.Text = lblBlue.Text = "000";
            lblColor.BackColor = System.Drawing.Color.Transparent;
            hsBlue.Value = hsGreen.Value = hsRed.Value = hsGreen.Minimum;
            
        }
        #region Scroll Bars
        private void hsRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsRed.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(
                Convert.ToByte(lblRed.Text),
                Convert.ToByte(lblGreen.Text),
                Convert.ToByte(lblBlue.Text));
        }

        private void hsGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsGreen.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(
                Convert.ToByte(lblRed.Text),
                Convert.ToByte(lblGreen.Text),
                Convert.ToByte(lblBlue.Text));
        }

        private void hsBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsBlue.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(
                Convert.ToByte(lblRed.Text),
                Convert.ToByte(lblGreen.Text),
                Convert.ToByte(lblBlue.Text));
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblColor.BackColor = System.Drawing.Color.FromArgb(
                Convert.ToByte(lblRed.Text),
                Convert.ToByte(lblGreen.Text),
                Convert.ToByte(lblBlue.Text));
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedColor = (Model.Color)lstColors.SelectedItem;
            lblPreview.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex == 0)
            {
                lblPreview.BackColor = System.Drawing.Color.Transparent;
            }
            if (lstColors.SelectedIndex < 0)
            {
                return;
            }
            var selectedColor = (Model.Color)lstColors.SelectedItem;
            db.Colors.Remove(selectedColor);
            db.SaveChanges();
            ListColors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex < 0)
            {
                return;
            }
            var selectedColor = (Model.Color)lstColors.SelectedItem;
            txtColorName.Text = selectedColor.ColorName;
            lblBlue.Text = selectedColor.Blue.ToString();
            lblGreen.Text = selectedColor.Green.ToString();
            lblRed.Text = selectedColor.Red.ToString();
            btnAdd.Text = "💾 Save";
            lblColor.BackColor = lblPreview.BackColor;
            hsGreen.Value = Convert.ToInt32(selectedColor.Green);
            hsRed.Value = Convert.ToInt32(selectedColor.Red);
            hsBlue.Value = Convert.ToInt32(selectedColor.Blue);
        }
    }
}
