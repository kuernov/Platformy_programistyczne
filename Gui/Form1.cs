using System.Runtime.CompilerServices;
using System;
using System.Windows.Forms;
using Platformy_lab1;
using System.Text;

[assembly: InternalsVisibleTo("Platformy_lab1")]

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshValues()
        {
            int numberOfItems, seed, capacity;

            if (!int.TryParse(textBox1.Text, out capacity))
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = SystemColors.Window;
            }

            if (!int.TryParse(textBox2.Text, out seed))
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox2.BackColor = SystemColors.Window;
            }

            if (!int.TryParse(textBox3.Text, out numberOfItems))
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = SystemColors.Window;
            }

            if (!int.TryParse(textBox3.Text, out numberOfItems) || !int.TryParse(textBox2.Text, out seed) || !int.TryParse(textBox1.Text, out capacity))
            {
                MessageBox.Show("Nieprawid�owe warto�ci. Wprowad� liczby ca�kowite.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ItemSet itemSet = new ItemSet(numberOfItems, seed);
            Result result = itemSet.Solution(capacity);

            textBox4.Text = result.ToString();

            List<Item> sortedItems = itemSet.Items.OrderBy(item => item.Id).ToList();

            StringBuilder itemsStringBuilder = new StringBuilder();
            foreach (var item in sortedItems)
            {
                itemsStringBuilder.AppendLine($"Item {item.Id}: Weight = {item.Weight}, Value = {item.Value}");
            }

            textBox5.Text = itemsStringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshValues();
        }






    }
}
