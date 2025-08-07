using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace lorena_task
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connection;
        public Form1()
        {
            have_read_Nodes = new List<DB_Node>();
            InitializeBD();
            InitializeComponent();
            InitTreeView();
        }

        private decimal CalculateResult(decimal price, decimal discount, decimal discount_parent) {
            return price - (price * ((discount + discount_parent) / 100));
        }

        private decimal CalculateDiscountPatent(DB_Node node) {
            //рекурсивный метод расчета скидки предков с учетом всех предков в дереве вплоть до корня
            decimal sum_discount_parent = 0;
            if (node.Dependence) {
                foreach (DB_Node el in have_read_Nodes)
                    if (node.Parent_id == el.Id){
                        sum_discount_parent += el.Discount;
                        return CalculateDiscountPatent(el) + sum_discount_parent;
                    }
                return sum_discount_parent;
            }
            return 0;
        }



        private List<System.Windows.Forms.TreeNode> GenTreeNodeList() {

            List<System.Windows.Forms.TreeNode> lst = new List<TreeNode> ();

            foreach (DB_Node el in have_read_Nodes) {
                if (!el.Dependence)
                    lst.Add( new System.Windows.Forms.TreeNode(     ) );


            }
            return lst;
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            decimal price = Convert.ToDecimal(textBox1.Text);
            //выделяем подстроку с именем салона
            string diller_name = Convert.ToString(Regex.Match(treeView2.SelectedNode.Text, @"^([\w\-]+)"));

            DB_Node node = new DB_Node();

            //ищем элемент среди считанных из БД по выделенной подстроке
            foreach (DB_Node el in have_read_Nodes)
                if (el.Name == diller_name)
                    node = el;
            //расчитываем скидку предка
            decimal discount_parent = CalculateDiscountPatent(node);

            //расчитываем итоговую стоимость
            decimal result = CalculateResult(price, node.Discount, discount_parent);
            //добавляем элемент в таблицу истории
            this.dataGridView2.Rows.Add(diller_name, price, node.Discount, discount_parent, result);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

           // this.dataGridView1.Rows.Clear();

            //выделяем подстроку с именем салона
            string diller_name = Convert.ToString(Regex.Match(treeView2.SelectedNode.Text, @"^([\w\-]+)"));

            DB_Node node = new DB_Node();

            //ищем элемент среди считанных из БД по выделенной подстроке
            foreach (DB_Node el in have_read_Nodes)
                if (el.Name == diller_name)
                    node = el;

            Func<bool, string> dep = (d) => { return d ? "Есть" : "Нет"; };

            this.textBox_name.Text = node.Name;
            this.textBox_name_discount.Text = node.Discount.ToString();
            this.textBox_dependence.Text = dep(node.Dependence);
            this.textBox_discription.Text = node.Discription;
           // this.dataGridView1.Rows.Add(node.Name, node.Discount, dep(node.Dependence) , node.Discription);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8) { 
                e.Handled = true;
            }
        }

        //ИНТЕРЙЕС ДЛЯ ТЕСТОВ
        //Установка цены в поле
        public void SetPrice(decimal price) { 
            textBox1.Text = price.ToString();
        }
        //выделить элемент в дереве
        public void SelectNode(string name) {
            //заглушка метода выбора работающая на одних исходных данных!!!
            if(name == "Амелия")
                treeView2.SelectedNode = treeView2.Nodes[0].Nodes[0];
            if (name == "Тест1")
                treeView2.SelectedNode = treeView2.Nodes[0].Nodes[0].Nodes[0];
            if (name == "Тест2")
                treeView2.SelectedNode = treeView2.Nodes[0].Nodes[1];
            if (name == "Курган")
                treeView2.SelectedNode = treeView2.Nodes[1];
            if (name == "Миасс")
                treeView2.SelectedNode = treeView2.Nodes[0];
        }
        //расчитать по формуле
        public decimal Calculate() {

            decimal price = Convert.ToDecimal(textBox1.Text);
            //выделяем подстроку с именем салона
            string diller_name = Convert.ToString(Regex.Match(treeView2.SelectedNode.Text, @"^([\w\-]+)"));

            DB_Node node = new DB_Node();

            //ищем элемент среди считанных из БД по выделенной подстроке
            foreach (DB_Node el in have_read_Nodes)
                if (el.Name == diller_name)
                    node = el;
            //расчитываем скидку предка
            decimal discount_parent = CalculateDiscountPatent(node);

            //расчитываем итоговую стоимость
            return CalculateResult(price, node.Discount, discount_parent); ;
        }

        private void sataButton1_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(textBox1.Text, out decimal price))
            {

                //decimal price = Convert.ToDecimal(textBox1.Text);

                // обработаь исклчюение!! System.FormatException: "Входная строка имела неверный формат."

                if (treeView2.SelectedNode != null)
                {
                    //выделяем подстроку с именем салона
                    string diller_name = Convert.ToString(Regex.Match(treeView2.SelectedNode.Text, @"^([\w\-]+)"));

                    DB_Node node = new DB_Node();

                    //ищем элемент среди считанных из БД по выделенной подстроке
                    foreach (DB_Node el in have_read_Nodes)
                        if (el.Name == diller_name)
                            node = el;
                    //расчитываем скидку предка
                    decimal discount_parent = CalculateDiscountPatent(node);

                    //расчитываем итоговую стоимость
                    decimal result = CalculateResult(price, node.Discount, discount_parent);
                    //добавляем элемент в таблицу истории
                    this.dataGridView2.Rows.Add(diller_name, price, node.Discount, discount_parent, result);
                }
                else {
                    MessageBox.Show("Выберете салон");
                }
            }
            else {

                MessageBox.Show("Введите цену");

            }
        }


        private void sataButton3_Click(object sender, EventArgs e) { 
            //добавить салон

            //вызвать диалоговое окно мастера добавления с формой для заполнения
            // задаваемые параметры  имя  - скидка - зависимость  - описание
            // для указания зависимости вывести список имен узлов дерева
            // найти в дереве элемент по выбраному имени и добавтиь к нему дочерний узел

        }

        private void sataButton4_Click(object sender, EventArgs e)
        {
            //удаление узла

            // првоерить какой элемент выделен и запомнить его имя

            //если листовой то просто удалить
            //если корневой то удалить все с предупреждающим диалоговым окном

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sataButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
    }
}
