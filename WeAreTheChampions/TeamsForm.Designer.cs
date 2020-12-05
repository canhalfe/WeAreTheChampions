
namespace WeAreTheChampions
{
    partial class frmTeamsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListPlayers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colorDialogFirst = new System.Windows.Forms.ColorDialog();
            this.colorDialogSecond = new System.Windows.Forms.ColorDialog();
            this.lblBg = new System.Windows.Forms.Label();
            this.lblBg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeams.BackColor = System.Drawing.Color.Black;
            this.lstTeams.DisplayMember = "TeamName";
            this.lstTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTeams.ForeColor = System.Drawing.Color.White;
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 16;
            this.lstTeams.Location = new System.Drawing.Point(15, 233);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(246, 308);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(14, 71);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(247, 21);
            this.txtTeamName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team Name:";
            // 
            // btnListPlayers
            // 
            this.btnListPlayers.BackColor = System.Drawing.Color.Black;
            this.btnListPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPlayers.ForeColor = System.Drawing.Color.White;
            this.btnListPlayers.Location = new System.Drawing.Point(133, 198);
            this.btnListPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.btnListPlayers.Name = "btnListPlayers";
            this.btnListPlayers.Size = new System.Drawing.Size(128, 30);
            this.btnListPlayers.TabIndex = 5;
            this.btnListPlayers.Text = "📜 List Players";
            this.btnListPlayers.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team Color:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(140, 546);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "🚮 Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(14, 546);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "🖋 Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 198);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+ Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // colorDialogFirst
            // 
            this.colorDialogFirst.AnyColor = true;
            this.colorDialogFirst.Color = System.Drawing.Color.Navy;
            this.colorDialogFirst.FullOpen = true;
            // 
            // colorDialogSecond
            // 
            this.colorDialogSecond.AnyColor = true;
            this.colorDialogSecond.Color = System.Drawing.Color.Navy;
            this.colorDialogSecond.FullOpen = true;
            // 
            // lblBg
            // 
            this.lblBg.BackColor = System.Drawing.Color.Transparent;
            this.lblBg.Location = new System.Drawing.Point(2, -1);
            this.lblBg.Name = "lblBg";
            this.lblBg.Size = new System.Drawing.Size(278, 12);
            this.lblBg.TabIndex = 12;
            // 
            // lblBg2
            // 
            this.lblBg2.BackColor = System.Drawing.Color.Transparent;
            this.lblBg2.Location = new System.Drawing.Point(2, 11);
            this.lblBg2.Name = "lblBg2";
            this.lblBg2.Size = new System.Drawing.Size(278, 12);
            this.lblBg2.TabIndex = 13;
            // 
            // frmTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(281, 599);
            this.Controls.Add(this.lblBg2);
            this.Controls.Add(this.lblBg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lstTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmTeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColorDialog colorDialogFirst;
        private System.Windows.Forms.ColorDialog colorDialogSecond;
        private System.Windows.Forms.Label lblBg;
        private System.Windows.Forms.Label lblBg2;
    }
}