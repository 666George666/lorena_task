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

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            decimal price = Convert.ToDecimal(textBox1.Text);
            //выделяем подстроку с именем салона
            string diller_name = Convert.ToString(Regex.Match(treeView1.SelectedNode.Text, @"^([\w\-]+)"));

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

            this.dataGridView1.Rows.Clear();

            //выделяем подстроку с именем салона
            string diller_name = Convert.ToString(Regex.Match(treeView1.SelectedNode.Text, @"^([\w\-]+)"));

            DB_Node node = new DB_Node();

            //ищем элемент среди считанных из БД по выделенной подстроке
            foreach (DB_Node el in have_read_Nodes)
                if (el.Name == diller_name)
                    node = el;

            Func<bool, string> dep = (d) => { return d ? "Есть" : "Нет"; };

            this.dataGridView1.Rows.Add(node.Name, node.Discount, dep(node.Dependence) , node.Discription);
        }
    }
}
