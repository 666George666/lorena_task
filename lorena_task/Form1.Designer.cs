using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace lorena_task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Diller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._per_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.sataButton1 = new FrameworkTest.SATAButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_discription = new System.Windows.Forms.TextBox();
            this.textBox_dependence = new System.Windows.Forms.TextBox();
            this.textBox_name_discount = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.discr = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.sataButton2 = new FrameworkTest.SATAButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sataPictureBox1 = new SATAUiFramework.Controls.SATAPictureBox();
            this.sataButton4 = new FrameworkTest.SATAButton();
            this.sataButton3 = new FrameworkTest.SATAButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sataButton5 = new FrameworkTest.SATAButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GOST type B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация о выбраном салоне";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("GOST type B", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("GOST type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Diller,
            this._price,
            this._discount,
            this._per_discount,
            this.result_price});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(258, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 60;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkOrange;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView2.Size = new System.Drawing.Size(503, 521);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Diller
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("GOST type B", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(204)));
            this.Diller.DefaultCellStyle = dataGridViewCellStyle3;
            this.Diller.HeaderText = "Салон";
            this.Diller.Name = "Diller";
            // 
            // _price
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._price.DefaultCellStyle = dataGridViewCellStyle4;
            this._price.HeaderText = "Цена, руб";
            this._price.Name = "_price";
            // 
            // _discount
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._discount.DefaultCellStyle = dataGridViewCellStyle5;
            this._discount.HeaderText = "Скидка, %";
            this._discount.Name = "_discount";
            this._discount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // _per_discount
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._per_discount.DefaultCellStyle = dataGridViewCellStyle6;
            this._per_discount.HeaderText = "Скидка предка, %";
            this._per_discount.Name = "_per_discount";
            // 
            // result_price
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_price.DefaultCellStyle = dataGridViewCellStyle7;
            this.result_price.HeaderText = "Расчетная стоимость, руб";
            this.result_price.Name = "result_price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GOST type B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "История расчета стоимости";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Цена, руб....";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 40;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // sataButton1
            // 
            this.sataButton1.ButtonText = "Рассчитать стоимость";
            this.sataButton1.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton1.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton1.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton1.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton1.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton1.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sataButton1.ForeColor = System.Drawing.SystemColors.Info;
            this.sataButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sataButton1.HoverForeColor = System.Drawing.Color.White;
            this.sataButton1.HoverImage = null;
            this.sataButton1.HoverImageTint = System.Drawing.Color.White;
            this.sataButton1.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton1.Image = null;
            this.sataButton1.ImageAutoCenter = true;
            this.sataButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton1.ImageTint = System.Drawing.Color.White;
            this.sataButton1.IsToggleButton = false;
            this.sataButton1.IsToggled = false;
            this.sataButton1.Location = new System.Drawing.Point(0, 171);
            this.sataButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sataButton1.Name = "sataButton1";
            this.sataButton1.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton1.NormalForeColor = System.Drawing.Color.White;
            this.sataButton1.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton1.OutlineThickness = 2F;
            this.sataButton1.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton1.PressedForeColor = System.Drawing.Color.White;
            this.sataButton1.PressedImageTint = System.Drawing.Color.White;
            this.sataButton1.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton1.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton1.Size = new System.Drawing.Size(206, 46);
            this.sataButton1.TabIndex = 6;
            this.sataButton1.TextAutoCenter = true;
            this.sataButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton1.Click += new System.EventHandler(this.sataButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.textBox_discription);
            this.panel1.Controls.Add(this.textBox_dependence);
            this.panel1.Controls.Add(this.textBox_name_discount);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.discr);
            this.panel1.Controls.Add(this.dep);
            this.panel1.Controls.Add(this.disc);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.sataButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 93);
            this.panel1.TabIndex = 8;
            // 
            // textBox_discription
            // 
            this.textBox_discription.Location = new System.Drawing.Point(328, 62);
            this.textBox_discription.Name = "textBox_discription";
            this.textBox_discription.Size = new System.Drawing.Size(423, 20);
            this.textBox_discription.TabIndex = 10;
            // 
            // textBox_dependence
            // 
            this.textBox_dependence.Location = new System.Drawing.Point(219, 62);
            this.textBox_dependence.Name = "textBox_dependence";
            this.textBox_dependence.Size = new System.Drawing.Size(100, 20);
            this.textBox_dependence.TabIndex = 10;
            // 
            // textBox_name_discount
            // 
            this.textBox_name_discount.Location = new System.Drawing.Point(113, 62);
            this.textBox_name_discount.Name = "textBox_name_discount";
            this.textBox_name_discount.Size = new System.Drawing.Size(100, 20);
            this.textBox_name_discount.TabIndex = 10;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(10, 62);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 10;
            // 
            // discr
            // 
            this.discr.AutoSize = true;
            this.discr.Font = new System.Drawing.Font("GOST type B", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.discr.Location = new System.Drawing.Point(325, 38);
            this.discr.Name = "discr";
            this.discr.Size = new System.Drawing.Size(83, 21);
            this.discr.TabIndex = 9;
            this.discr.Text = "Описание";
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Font = new System.Drawing.Font("GOST type B", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dep.Location = new System.Drawing.Point(216, 38);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(111, 21);
            this.dep.TabIndex = 9;
            this.dep.Text = "Зависимость";
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Font = new System.Drawing.Font("GOST type B", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.disc.Location = new System.Drawing.Point(110, 38);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(95, 21);
            this.disc.TabIndex = 9;
            this.disc.Text = "Скидка, %";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("GOST type B", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.name.Location = new System.Drawing.Point(7, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 21);
            this.name.TabIndex = 9;
            this.name.Text = "Имя";
            // 
            // sataButton2
            // 
            this.sataButton2.ButtonText = "";
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
            this.sataButton2.Image = global::lorena_task.Properties.Resources.icons8_close_50;
            this.sataButton2.ImageAutoCenter = true;
            this.sataButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageTint = System.Drawing.Color.White;
            this.sataButton2.IsToggleButton = false;
            this.sataButton2.IsToggled = false;
            this.sataButton2.Location = new System.Drawing.Point(726, 0);
            this.sataButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButton2.Name = "sataButton2";
            this.sataButton2.NormalBackground = System.Drawing.Color.AliceBlue;
            this.sataButton2.NormalForeColor = System.Drawing.Color.White;
            this.sataButton2.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton2.OutlineThickness = 2F;
            this.sataButton2.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton2.PressedForeColor = System.Drawing.Color.White;
            this.sataButton2.PressedImageTint = System.Drawing.Color.White;
            this.sataButton2.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton2.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton2.Size = new System.Drawing.Size(43, 21);
            this.sataButton2.TabIndex = 8;
            this.sataButton2.TextAutoCenter = true;
            this.sataButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton2.Click += new System.EventHandler(this.sataButton2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(88)))), ((int)(((byte)(3)))));
            this.panel2.Controls.Add(this.sataPictureBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.sataButton5);
            this.panel2.Controls.Add(this.sataButton4);
            this.panel2.Controls.Add(this.sataButton3);
            this.panel2.Controls.Add(this.sataButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(206, 643);
            this.panel2.MinimumSize = new System.Drawing.Size(206, 643);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 643);
            this.panel2.TabIndex = 9;
            // 
            // sataPictureBox1
            // 
            this.sataPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.sataPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.sataPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.sataPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sataPictureBox1.BorderSize = 1;
            this.sataPictureBox1.GradientAngle = 50F;
            this.sataPictureBox1.Image = global::lorena_task.Properties.Resources.logo;
            this.sataPictureBox1.InitialImage = global::lorena_task.Properties.Resources.logo;
            this.sataPictureBox1.Location = new System.Drawing.Point(59, 9);
            this.sataPictureBox1.Name = "sataPictureBox1";
            this.sataPictureBox1.Size = new System.Drawing.Size(73, 73);
            this.sataPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sataPictureBox1.TabIndex = 7;
            this.sataPictureBox1.TabStop = false;
            // 
            // sataButton4
            // 
            this.sataButton4.ButtonText = "Удалить салон";
            this.sataButton4.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton4.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton4.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton4.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton4.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton4.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sataButton4.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sataButton4.HoverForeColor = System.Drawing.Color.White;
            this.sataButton4.HoverImage = null;
            this.sataButton4.HoverImageTint = System.Drawing.Color.White;
            this.sataButton4.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton4.Image = global::lorena_task.Properties.Resources.icons8_delete_bookmark_50;
            this.sataButton4.ImageAutoCenter = true;
            this.sataButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton4.ImageTint = System.Drawing.Color.White;
            this.sataButton4.IsToggleButton = false;
            this.sataButton4.IsToggled = false;
            this.sataButton4.Location = new System.Drawing.Point(0, 327);
            this.sataButton4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sataButton4.Name = "sataButton4";
            this.sataButton4.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton4.NormalForeColor = System.Drawing.Color.White;
            this.sataButton4.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton4.OutlineThickness = 2F;
            this.sataButton4.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton4.PressedForeColor = System.Drawing.Color.White;
            this.sataButton4.PressedImageTint = System.Drawing.Color.White;
            this.sataButton4.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton4.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton4.Size = new System.Drawing.Size(206, 46);
            this.sataButton4.TabIndex = 6;
            this.sataButton4.TextAutoCenter = true;
            this.sataButton4.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton4.Click += new System.EventHandler(this.sataButton4_Click);
            // 
            // sataButton3
            // 
            this.sataButton3.ButtonText = "Добавить салон";
            this.sataButton3.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton3.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton3.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton3.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton3.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton3.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sataButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sataButton3.HoverForeColor = System.Drawing.Color.White;
            this.sataButton3.HoverImage = null;
            this.sataButton3.HoverImageTint = System.Drawing.Color.White;
            this.sataButton3.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton3.Image = global::lorena_task.Properties.Resources.icons8_delete_bookmark_50;
            this.sataButton3.ImageAutoCenter = true;
            this.sataButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton3.ImageTint = System.Drawing.Color.White;
            this.sataButton3.IsToggleButton = false;
            this.sataButton3.IsToggled = false;
            this.sataButton3.Location = new System.Drawing.Point(0, 249);
            this.sataButton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sataButton3.Name = "sataButton3";
            this.sataButton3.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton3.NormalForeColor = System.Drawing.Color.White;
            this.sataButton3.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton3.OutlineThickness = 2F;
            this.sataButton3.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton3.PressedForeColor = System.Drawing.Color.White;
            this.sataButton3.PressedImageTint = System.Drawing.Color.White;
            this.sataButton3.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton3.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton3.Size = new System.Drawing.Size(206, 46);
            this.sataButton3.TabIndex = 6;
            this.sataButton3.TextAutoCenter = true;
            this.sataButton3.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton3.Click += new System.EventHandler(this.sataButton3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.treeView2);
            this.panel3.Location = new System.Drawing.Point(206, 88);
            this.panel3.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 555);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orchid;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(258, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 36);
            this.panel4.TabIndex = 5;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView2.Font = new System.Drawing.Font("GOST type B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.treeView2.ImageKey = "citycons_building-512_9481.png";
            this.treeView2.ImageList = this.imageList1;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(258, 555);
            this.treeView2.TabIndex = 4;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "citycons_building-512_9481.png");
            this.imageList1.Images.SetKeyName(1, "lorena1.jpg");
            // 
            // sataButton5
            // 
            this.sataButton5.ButtonText = "Очистить историю";
            this.sataButton5.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton5.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton5.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton5.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.sataButton5.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton5.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sataButton5.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sataButton5.HoverForeColor = System.Drawing.Color.White;
            this.sataButton5.HoverImage = null;
            this.sataButton5.HoverImageTint = System.Drawing.Color.White;
            this.sataButton5.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton5.Image = global::lorena_task.Properties.Resources.icons8_close_50;
            this.sataButton5.ImageAutoCenter = true;
            this.sataButton5.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.sataButton5.ImageTint = System.Drawing.Color.White;
            this.sataButton5.IsToggleButton = false;
            this.sataButton5.IsToggled = false;
            this.sataButton5.Location = new System.Drawing.Point(0, 536);
            this.sataButton5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sataButton5.Name = "sataButton5";
            this.sataButton5.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.sataButton5.NormalForeColor = System.Drawing.Color.White;
            this.sataButton5.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton5.OutlineThickness = 2F;
            this.sataButton5.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButton5.PressedForeColor = System.Drawing.Color.White;
            this.sataButton5.PressedImageTint = System.Drawing.Color.White;
            this.sataButton5.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton5.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton5.Size = new System.Drawing.Size(206, 46);
            this.sataButton5.TabIndex = 6;
            this.sataButton5.TextAutoCenter = true;
            this.sataButton5.TextOffset = new System.Drawing.Point(0, 0);
            this.sataButton5.Click += new System.EventHandler(this.sataButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(969, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;


        private void InitializeBD()
        {

                //###########################################################################################
                //1 - ПОДГОТОВКА ДАННЫХ ДЛЯ ВСТАВКИ ПО УМОЛЧАНИЮ
                List<DB_Node> dB_Nodes = new List<DB_Node>();
                dB_Nodes.Add(new DB_Node(1, "Миасс", 4, false, 0, "Это описание  Миасскаого подразделения"));
                dB_Nodes.Add(new DB_Node(2, "Амелия", 5, true, 1, "Это описание  подразделения Амелия"));
                dB_Nodes.Add(new DB_Node(3, "Тест1", 2, true, 2, "Это описание  подразделения Тест1"));
                dB_Nodes.Add(new DB_Node(4, "Тест2", 0, true, 1, "Это описание  подразделения Тест2"));
                dB_Nodes.Add(new DB_Node(5, "Курган", 11, false, 0, "Это описание  подразделения Курган"));
                //###########################################################################################
                // 2 -  УСТАНОВЛЕНИЕ СОЕДИНЕНИЯ С БД
                string dbPath = "lorena_data.db";//путь к базе данных в папке с проектом

                if (!File.Exists(dbPath)) {


                //3 - СОЗДАНИЕ И ОТКРЫТИЕ БД
                using (connection = new SQLiteConnection($"Data Source = {dbPath};Version = 3"))
                    {
                        connection.Open();

                    //#######################

                    //#############предаврительная натсрйока на возможность каскадного удаления
                    using (SQLiteCommand command = new SQLiteCommand("PRAGMA foreign_keys = ON;", connection))
                    {
                        command.ExecuteNonQuery();
                    }



                    //3 СОЗДАНИЕ ТАБЛИЦЫ
                    using (SQLiteCommand command = new SQLiteCommand(
                            "CREATE TABLE IF NOT EXISTS DillerTree(" +
                                "Id             INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
                                "Name           TEXT NOT NULL," +
                                "Discount       REAL NOT NULL," +
                                "Dependence     INTEGER NOT NULL," +
                                "Parent_id      INTEGER REFERENCES DillerTree(Id) ON DELETE CASCADE," +
                                "Discription    TEXT(124) NOT NULL," +
                                "FOREIGN KEY(Parent_id) REFERENCES DillerTree(Id) ON DELETE CASCADE);"
                                , connection))
                        {
                            command.ExecuteNonQuery();
                        }





                    //4 -  ДОБАВЛЕНИЕ НАЧАЛЬНЫХ ДАННЫХ В ТАБЛИЦУ
                    foreach (DB_Node el in dB_Nodes)
                        {
                            using (SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO DillerTree(Name,Discount,Dependence,Parent_id,Discription) VALUES (@Name, @Discount, @Dependence , @Parent_id,  @Discription)", connection))
                            {
                            
                                if (!(el.Parent_id == 0)) {
                                
                                    //insertCommand.Parameters.AddWithValue("@Id", el.Id);
                                    insertCommand.Parameters.AddWithValue("@Name", el.Name);
                                    insertCommand.Parameters.AddWithValue("@Discount", el.Discount);
                                    insertCommand.Parameters.AddWithValue("@Dependence", el.Dependence);
                                    insertCommand.Parameters.AddWithValue("@Parent_id", el.Parent_id);
                                    insertCommand.Parameters.AddWithValue("@Discription", el.Discription);
                                    insertCommand.ExecuteNonQuery();

                                }
                                else {
                                    //insertCommand.Parameters.AddWithValue("@Id", el.Id);
                                    insertCommand.Parameters.AddWithValue("@Name", el.Name);
                                    insertCommand.Parameters.AddWithValue("@Discount", el.Discount);
                                    insertCommand.Parameters.AddWithValue("@Dependence", el.Dependence);
                                    insertCommand.Parameters.AddWithValue("@Parent_id", DBNull.Value);
                                    insertCommand.Parameters.AddWithValue("@Discription", el.Discription);
                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }

                    }
                }
                //###########################################################################################
        }


        //public bool CheckIfSQLiteDatabaseExists(string dbFilePath)
       // {
            //try
            //{
            //    // Пробуем создать подключение к существующему файлу БД
            //    using var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");

            //    // Открываем соединение с базой данных
            //    connection.Open();

            //    return true; // Если открытие прошло успешно, значит база существует
            //}
            //catch (SQLiteException ex)
            //{
            //    if (ex.ErrorCode == SQLiteErrorCode.CANTOPEN || ex.ErrorCode == SQLiteErrorCode.IOERR)
            //        return false; // Файл отсутствует или файл поврежден

            //    throw; // Повторяем исключение вверх по стеку, если ошибка другого типа
            //}
      //  }


        private void InitTreeView(){

            //ЧТЕНИЕ ВСЕХ ДАННЫХ ИЗ БД И СОХРАНЕНИЕ В КОНТЕЙНЕРЕ
            List<DB_Node> have_read_dB_Nodes = Read_All_db_Nodes();
            have_read_Nodes = have_read_dB_Nodes;
            //###########################################################################################
            //СОЗДАНИЕ ЭЛЕМЕНТОВ ДРЕВОВИДНОГО ПРЕДСТАВЛЕНИЯ
            List<System.Windows.Forms.TreeNode> lst_FormsTree_Node = new List<System.Windows.Forms.TreeNode>();

            foreach (DB_Node el in have_read_dB_Nodes){//просматриваем загруженные из БД элементы
                if (!el.Dependence)
                {//если зависимости нет то просто создаем корнейвой элемент
                    lst_FormsTree_Node.Add( new System.Windows.Forms.TreeNode(el.Name) );
                    lst_FormsTree_Node.Last().Name = el.Name;//задаем имя узла такое же как и текст узла
                }
                else{
                    string temp_substr = "";
                    //1 если есть зависимость то ищем имя родителя по идентификатору в загруженных из БД элементов
                    //и запоминаем имя элемента предка
                    foreach (DB_Node el1 in have_read_dB_Nodes)
                        if (el1.Id == el.Parent_id) {
                             temp_substr = el1.Name;//запоминаем имя элемента предка что бы затем выполнить поиск имени по ключу
                            break;
                            //в уже сформированных элементах древовидной стурктуры
                        }

                     //2- если есть зависимость - просмотреть корневые элементы которые уже добавлены
                     foreach (System.Windows.Forms.TreeNode el2 in lst_FormsTree_Node) {

                        if (el2.Name == temp_substr)
                        {
                            el2.Nodes.Add(new System.Windows.Forms.TreeNode{Text = el.Name, Name = el.Name }   );
                            
                            break;
                        }
                        //сначала проверка не является ли корневой элементом с ключем (в ситуации когда ни один не добавлен)
                        //3- выполнить поиск по ключу (он вроде задается) вплоть до листа
                        else
                        {
                            TreeNode[] colection_find = el2.Nodes.Find(temp_substr, true);//ЗДЕСЬ ПОЧЕМУ ТО ЗАТЫК (ЗДЕСЬ ПЫТАЮСЬ НАЙТИ ТО ЧЕГО НЕТ ведь изначально я не добавил еще)!
                            if (colection_find.Length != 0)
                            {
                                //4- если нашли элемент с ключем (по имени узла), то по этой ссылке (а это точно ссылка?) вставляем потомка 
                                colection_find.First().Nodes.Add(new System.Windows.Forms.TreeNode { Text = el.Name, Name = el.Name });
                                break;
                            }
                        
                        }
                     }
                }
            }

            foreach (System.Windows.Forms.TreeNode el in lst_FormsTree_Node)
                          this.treeView2.Nodes.Add(el);

            this.treeView2.ExpandAll();//раскрыть все элементы
        }

        private List<DB_Node> Read_All_db_Nodes() {
            List<DB_Node> have_read_dB_Nodes = new List<DB_Node>();
            string dbPath = "lorena_data.db";//ОТКРЫВАЕМ СОЗДАННУЮ БД заного так как using вызывает деструктор
            using (connection = new SQLiteConnection($"Data Source = {dbPath};Version = 3")){
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM DillerTree", connection))
                {
                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            have_read_dB_Nodes.Add(new DB_Node(
                                                       Convert.ToInt16(reader["Id"]),
                                                       Convert.ToString(reader["Name"]),
                                                       Convert.ToInt16(reader["Discount"]),
                                                       Convert.ToBoolean(reader["Dependence"]),
                                                       (reader["Parent_id"] == DBNull.Value ? default(int) : Convert.ToInt16(reader["Parent_id"]) ),
                                                       Convert.ToString(reader["Discription"])));
                        }
                    }
                }
            }
                return have_read_dB_Nodes;
        }
        private List<DB_Node> have_read_Nodes;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private FrameworkTest.SATAButton sataButton1;
        private SATAUiFramework.Controls.SATAPictureBox sataPictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private FrameworkTest.SATAButton sataButton2;
        private FrameworkTest.SATAButton sataButton3;
        private TreeView treeView2;
        private Panel panel4;
        private Label name;
        private TextBox textBox_discription;
        private TextBox textBox_dependence;
        private TextBox textBox_name_discount;
        private TextBox textBox_name;
        private Label discr;
        private Label dep;
        private Label disc;
        private DataGridViewTextBoxColumn Diller;
        private DataGridViewTextBoxColumn _price;
        private DataGridViewTextBoxColumn _discount;
        private DataGridViewTextBoxColumn _per_discount;
        private DataGridViewTextBoxColumn result_price;
        private FrameworkTest.SATAButton sataButton4;
        private ImageList imageList1;
        private FrameworkTest.SATAButton sataButton5;
    }
}

