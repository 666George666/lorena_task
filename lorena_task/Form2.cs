using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lorena_task
{
    public partial class Form2 : Form
    {
        public Form2(List<string> lst)
        {
            InitializeComponent();

            //добавляем список имен (НО ЭТО РАБОАТЕТ ТОЛЬКО ЕСЛИ БАЗА УЖЕ ЕСТЬ И ПРИ ППЕРВОМ ЗАПУСКЕ (ДОБАВЬ ПОТОМ!))
            foreach (string s in lst)
                this.add_dep_line.Items.Add(s);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sataButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetNameLine() { return this.add_name_line.Text; }
        public string GetDiscLine() { return this.add_disc_line.Text; }
        public string GetDisripLine() { return this.add_discrip_line.Text; }
        public string GetDepLine() { return this.add_dep_line.Text; }

        private void add_disc_line_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или специальным символом управления (например, Backspace).
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Если символ не цифра и не управляющий символ, отменяем событие ввода.
                e.Handled = true;
            }
        }

        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void AddButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetNameLine().Length == 0)
            {
                MessageBox.Show("Ввдеите имя!");
                return;
            }
            if (GetDiscLine().Length == 0)
            {
                MessageBox.Show("Ввдеите скидку!");
                return;
            }
            if (GetDisripLine().Length == 0)
            {
                MessageBox.Show("Ввдеите описание!");
                return;
            }
        }
    }
}
