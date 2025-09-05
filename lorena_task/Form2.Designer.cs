namespace lorena_task
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_name_line = new System.Windows.Forms.TextBox();
            this.add_disc_line = new System.Windows.Forms.TextBox();
            this.add_discrip_line = new System.Windows.Forms.TextBox();
            this.sataButton2 = new FrameworkTest.SATAButton();
            this.add_dep_line = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скидка, %";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Зависимость";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Описание";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // add_name_line
            // 
            this.add_name_line.Location = new System.Drawing.Point(8, 31);
            this.add_name_line.Name = "add_name_line";
            this.add_name_line.Size = new System.Drawing.Size(100, 20);
            this.add_name_line.TabIndex = 2;
            // 
            // add_disc_line
            // 
            this.add_disc_line.Location = new System.Drawing.Point(114, 31);
            this.add_disc_line.Name = "add_disc_line";
            this.add_disc_line.Size = new System.Drawing.Size(100, 20);
            this.add_disc_line.TabIndex = 2;
            this.add_disc_line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_disc_line_KeyPress);
            // 
            // add_discrip_line
            // 
            this.add_discrip_line.Location = new System.Drawing.Point(326, 31);
            this.add_discrip_line.Name = "add_discrip_line";
            this.add_discrip_line.Size = new System.Drawing.Size(100, 20);
            this.add_discrip_line.TabIndex = 2;
            // 
            // sataButton2
            // 
            this.sataButton2.ButtonText = "Отменить";
            this.sataButton2.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton2.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton2.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton2.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton2.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.sataButton2.HoverForeColor = System.Drawing.Color.White;
            this.sataButton2.HoverImage = null;
            this.sataButton2.HoverImageTint = System.Drawing.Color.White;
            this.sataButton2.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton2.Image = null;
            this.sataButton2.ImageAutoCenter = true;
            this.sataButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageTint = System.Drawing.Color.White;
            this.sataButton2.IsToggleButton = false;
            this.sataButton2.IsToggled = false;
            this.sataButton2.Location = new System.Drawing.Point(338, 74);
            this.sataButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButton2.Name = "sataButton2";
            this.sataButton2.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton2.NormalForeColor = System.Drawing.Color.White;
            this.sataButton2.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton2.OutlineThickness = 2F;
            this.sataButton2.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton2.PressedForeColor = System.Drawing.Color.White;
            this.sataButton2.PressedImageTint = System.Drawing.Color.White;
            this.sataButton2.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton2.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton2.Size = new System.Drawing.Size(88, 30);
            this.sataButton2.TabIndex = 4;
            this.sataButton2.TextAutoCenter = true;
            this.sataButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton2.Click += new System.EventHandler(this.sataButton2_Click);
            // 
            // add_dep_line
            // 
            this.add_dep_line.FormattingEnabled = true;
            this.add_dep_line.Location = new System.Drawing.Point(220, 26);
            this.add_dep_line.Name = "add_dep_line";
            this.add_dep_line.Size = new System.Drawing.Size(100, 30);
            this.add_dep_line.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddButton.Location = new System.Drawing.Point(231, 74);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 30);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseClick);
            this.AddButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(442, 116);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.add_dep_line);
            this.Controls.Add(this.sataButton2);
            this.Controls.Add(this.add_discrip_line);
            this.Controls.Add(this.add_disc_line);
            this.Controls.Add(this.add_name_line);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add_name_line;
        private System.Windows.Forms.TextBox add_disc_line;
        private System.Windows.Forms.TextBox add_discrip_line;
        private FrameworkTest.SATAButton sataButton2;
        private System.Windows.Forms.ListBox add_dep_line;
        private System.Windows.Forms.Button AddButton;
    }
}