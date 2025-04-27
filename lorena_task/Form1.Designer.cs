using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Timers;
using System.Windows.Forms;
using System.IO;

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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dependence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Diller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._per_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена, руб";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Discount,
            this.Dependence,
            this.Discription});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(363, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 75);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Имя";
            this.Name_.Name = "Name_";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Скидка, %";
            this.Discount.Name = "Discount";
            // 
            // Dependence
            // 
            this.Dependence.HeaderText = "Зависимость";
            this.Dependence.Name = "Dependence";
            // 
            // Discription
            // 
            this.Discription.HeaderText = "Описание";
            this.Discription.Name = "Discription";
            this.Discription.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(574, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация о выбраном салоне";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Diller,
            this._price,
            this._discount,
            this._per_discount,
            this.result_price});
            this.dataGridView2.Location = new System.Drawing.Point(440, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 313);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Diller
            // 
            this.Diller.HeaderText = "Салон";
            this.Diller.Name = "Diller";
            // 
            // _price
            // 
            this._price.HeaderText = "Цена, руб";
            this._price.Name = "_price";
            // 
            // _discount
            // 
            this._discount.HeaderText = "Скидка, %";
            this._discount.Name = "_discount";
            // 
            // _per_discount
            // 
            this._per_discount.HeaderText = "Скидка предка, %";
            this._per_discount.Name = "_per_discount";
            // 
            // result_price
            // 
            this.result_price.HeaderText = "Расчетная стоимость, руб";
            this.result_price.Name = "result_price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(574, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "История расчета стоимости";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 177);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(345, 445);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(109, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(363, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(701, 162);
            this.button1.TabIndex = 5;
            this.button1.Text = "Рассчитать стоимость для выбранного салона";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dependence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;


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

            if( !File.Exists(dbPath)) {

                //3 - СОЗДАНИЕ И ОТКРЫТИЕ БД
                using (connection = new SQLiteConnection($"Data Source = {dbPath};Version = 3"))
                {
                    connection.Open();
                    //3 СОЗДАНИЕ ТАБЛИЦЫ
                    using (SQLiteCommand command = new SQLiteCommand(
                        "CREATE TABLE IF NOT EXISTS DillerTree(" +
                            "Id             INTEGER PRIMARY KEY NOT NULL UNIQUE," +
                            "Name           TEXT NOT NULL," +
                            "Discount       REAL NOT NULL," +
                            "Dependence     INTEGER NOT NULL," +
                            "Parent_id      INTEGER NOT NULL," +
                            "Discription    TEXT(124) NOT NULL  ," +
                            "FOREIGN KEY(Parent_id) REFERENCES DillerTree(Id) )",
                            connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    //4 -  ДОБАВЛЕНИЕ НАЧАЛЬНЫХ ДАННЫХ В ТАБЛИЦУ
                    foreach (DB_Node el in dB_Nodes)
                    {
                        using (SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO DillerTree(Id,Name,Discount,Dependence,Parent_id,Discription) VALUES (@Id, @Name, @Discount, @Dependence , @Parent_id,  @Discription)", connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Id", el.Id);
                            insertCommand.Parameters.AddWithValue("@Name", el.Name);
                            insertCommand.Parameters.AddWithValue("@Discount", el.Discount);
                            insertCommand.Parameters.AddWithValue("@Dependence", el.Dependence);
                            insertCommand.Parameters.AddWithValue("@Parent_id", el.Parent_id);
                            insertCommand.Parameters.AddWithValue("@Discription", el.Discription);
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                }
            }
            //###########################################################################################
        }


        private void InitTreeView(){

            //ЧТЕНИЕ ВСЕХ ДАННЫХ ИЗ БД И СОХРАНЕНИЕ В КОНТЕЙНЕРЕ
            List<DB_Node> have_read_dB_Nodes = Read_All_db_Nodes();
            have_read_Nodes = have_read_dB_Nodes;
            //###########################################################################################
            //СОЗДАНИЕ ЭЛЕМЕНТОВ ДРЕВОВИДНОГО ПРЕДСТАВЛЕНИЯ
            List<System.Windows.Forms.TreeNode> lst_FormsTree_Node = new List<System.Windows.Forms.TreeNode>();//контейнер для хранения

            //foreach (DB_Node el in have_read_dB_Nodes) {//просматриваем загруженные из БД элементы

            //    if (! el.Dependence){//если зависимости нет то просто создаем корнейвой элемент
            //        lst_FormsTree_Node.Add( new System.Windows.Forms.TreeNode( el.Name + " (скидка "+ el.Discount + "%, зависимости нет)" ));
            //    }
            //    else {
            //        //если есть зависимость то ищем родителя по идентификатору в загруженных из БД элементов
            //        foreach (DB_Node el2 in have_read_dB_Nodes)
            //            if (el2.Id == el.Parent_id){//если нашли идентификатор
            //                string temp_substr = el2.Name;//запоминаем имя элемента предка
            //                foreach (System.Windows.Forms.TreeNode el3 in lst_FormsTree_Node) { // ищем подстроку с именем в уже созданных узлах
            //                    if ( ! Convert.ToBoolean( el3.Text.IndexOf(temp_substr) ) ) 
            //                            el3.Nodes.Add( new System.Windows.Forms.TreeNode(el.Name + " (скидка " + el.Discount + "%, зависимость есть)") ); 
            //                     }
            //            }
            //    }
            //}

            //ПРОТОТИП ДЛЯ ФОРМИРОВАНИЯ СТРУКТУРЫ
        //            private decimal CalculateDiscountPatent(DB_Node node)
        //{
        //    //рекурсивный метод расчета скидки предков с учетом всех предков в дереве вплоть до корня
        //    decimal sum_discount_parent = 0;
        //    if (node.Dependence)
        //    {
        //        foreach (DB_Node el in have_read_Nodes)
        //            if (node.Parent_id == el.Id)
        //            {
        //                sum_discount_parent += el.Discount;
        //                return CalculateDiscountPatent(el) + sum_discount_parent;
        //            }
        //        return sum_discount_parent;
        //    }
        //    return 0;
        //}




        //--------------------------------------------РЕАЛИЗАЦИЯ ЗАГЛУШЕК
        System.Windows.Forms.TreeNode Miass     = new System.Windows.Forms.TreeNode("Миасс" + " (скидка " + "4" + "%, зависимости нет)");

            System.Windows.Forms.TreeNode Amelia    = new System.Windows.Forms.TreeNode("Амелия" + " (скидка " + "5" + "%, зависимость есть)");

            System.Windows.Forms.TreeNode Test1     = new System.Windows.Forms.TreeNode("Тест1" + " (скидка " + "2" + "%, зависимость есть)");

            System.Windows.Forms.TreeNode Test2     = new System.Windows.Forms.TreeNode("Тест2" + " (скидка " + "0" + "%, зависимость есть)");

            System.Windows.Forms.TreeNode Kurgan    = new System.Windows.Forms.TreeNode("Курган" + " (скидка " + "11" + "%, зависимости нет)");


            Amelia.Nodes.Add(Test1);
            Miass.Nodes.Add(Amelia);
            Miass.Nodes.Add(Test2);

            this.treeView1.Nodes.Add(Miass);
            this.treeView1.Nodes.Add(Kurgan);


            //foreach (System.Windows.Forms.TreeNode el in lst_FormsTree_Node)
            //    this.treeView1.Nodes.Add(el);


            this.Controls.Add(this.treeView1);
            this.treeView1.ExpandAll();

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
                            //Console.WriteLine($"   Id:{reader["Id"]} , Name:{reader["Name"]},  Value:{reader["Value"]}");


                            have_read_dB_Nodes.Add(new DB_Node(
                                                       Convert.ToInt16(reader["Id"]),
                                                       Convert.ToString(reader["Name"]),
                                                       Convert.ToInt16(reader["Discount"]),
                                                       Convert.ToBoolean(reader["Dependence"]),
                                                       Convert.ToInt16(reader["Parent_id"]),
                                                       Convert.ToString(reader["Discription"])));
                        }
                    }
                }
            }
                return have_read_dB_Nodes;
        }
        private List<DB_Node> have_read_Nodes;
        private Button button1;
        private DataGridViewTextBoxColumn Diller;
        private DataGridViewTextBoxColumn _price;
        private DataGridViewTextBoxColumn _discount;
        private DataGridViewTextBoxColumn _per_discount;
        private DataGridViewTextBoxColumn result_price;
    }
}

