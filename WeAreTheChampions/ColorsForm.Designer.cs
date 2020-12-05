
namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.hsRed = new System.Windows.Forms.HScrollBar();
            this.hsGreen = new System.Windows.Forms.HScrollBar();
            this.hsBlue = new System.Windows.Forms.HScrollBar();
            this.lblColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(69, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+ Add Color";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstColors
            // 
            this.lstColors.DisplayMember = "ColorName";
            this.lstColors.FormattingEnabled = true;
            this.lstColors.ItemHeight = 15;
            this.lstColors.Location = new System.Drawing.Point(224, 193);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(166, 169);
            this.lstColors.TabIndex = 4;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(110, 193);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(108, 21);
            this.txtColorName.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(19, 282);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 27);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "🖋 Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(131, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "🚮 Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // hsRed
            // 
            this.hsRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsRed.LargeChange = 1;
            this.hsRed.Location = new System.Drawing.Point(110, 84);
            this.hsRed.Maximum = 255;
            this.hsRed.Name = "hsRed";
            this.hsRed.Size = new System.Drawing.Size(280, 17);
            this.hsRed.TabIndex = 8;
            this.hsRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsRed_Scroll);
            // 
            // hsGreen
            // 
            this.hsGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsGreen.LargeChange = 1;
            this.hsGreen.Location = new System.Drawing.Point(110, 117);
            this.hsGreen.Maximum = 255;
            this.hsGreen.Name = "hsGreen";
            this.hsGreen.Size = new System.Drawing.Size(280, 17);
            this.hsGreen.TabIndex = 9;
            this.hsGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsGreen_Scroll);
            // 
            // hsBlue
            // 
            this.hsBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hsBlue.LargeChange = 1;
            this.hsBlue.Location = new System.Drawing.Point(110, 155);
            this.hsBlue.Maximum = 255;
            this.hsBlue.Name = "hsBlue";
            this.hsBlue.Size = new System.Drawing.Size(280, 17);
            this.hsBlue.TabIndex = 10;
            this.hsBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsBlue_Scroll);
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(19, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(371, 17);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color Label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Red";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Blue";
            // 
            // lblPreview
            // 
            this.lblPreview.Location = new System.Drawing.Point(396, 193);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(13, 169);
            this.lblPreview.TabIndex = 15;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(79, 157);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 15);
            this.lblBlue.TabIndex = 18;
            this.lblBlue.Text = "000";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(79, 84);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(28, 15);
            this.lblRed.TabIndex = 19;
            this.lblRed.Text = "000";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(79, 119);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(28, 15);
            this.lblGreen.TabIndex = 20;
            this.lblGreen.Text = "000";
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(424, 400);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.hsBlue);
            this.Controls.Add(this.hsGreen);
            this.Controls.Add(this.hsRed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.HScrollBar hsRed;
        private System.Windows.Forms.HScrollBar hsGreen;
        private System.Windows.Forms.HScrollBar hsBlue;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
    }
}