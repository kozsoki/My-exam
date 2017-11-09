using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Licenta
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        List<string> data = new List<string>();

        public void refresh() 
        {
            data.Clear();
            data.Add("Domeniu : " + textBox1.Text);
            data.Add("Nivel : " + numericUpDown1.Value);
            data.Add("Titlu : " + textBox2.Text);
            foreach (string s in listBox2.Items)
            {
                data.Add("Text intrebare : " + s);
            }
            data.Add("endl");
            data.Add("Hint : " + textBox4.Text);
            foreach (string s in listBox3.Items)
            {
                data.Add("Text raspuns : " + s);
            }
            data.Add("endl");
            data.Add("Indice RC : " + numericUpDown2.Value);
            data.Add("Image : " + comboBox1.SelectedItem);
            data.Add("Punctaj : " + numericUpDown3.Value);
            data.Add("Timp : " + numericUpDown4.Value);


            listBox1.Items.Clear();
            foreach (string s in data)
                listBox1.Items.Add(s);

        }
        private void Create_Load(object sender, EventArgs e)
        {
            textBox6.Text = "a";
            for (int i = 0; i < 10; i++)
            {
                textBox6.Text += Engine.rnd.Next(10).ToString();
            }
            numericUpDown2.Minimum = 0;
            numericUpDown2.Value = 0;
            numericUpDown2.Maximum = 0;
        }

        private void LOAD_IMAGE_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] files = Directory.GetFiles(@"..\..\Imagini\");
            comboBox1.Items.Add("null");
            foreach (string s in files) comboBox1.Items.Add(s);

        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void ADD_TEXT_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
        }

        private void DEL_TEXT_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void ADD_ANSW_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox5.Text);
            numericUpDown2.Maximum = listBox3.Items.Count-1;
        }

        private void DEL_ANSW_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            numericUpDown2.Minimum = 0;
            numericUpDown2.Value = 0;
            numericUpDown2.Maximum = 0;
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool valid() 
        {
            if (listBox3.Items.Count == 0)
                return false;
            return true;
        }
        private void SAVE_Click(object sender, EventArgs e)
        {
            if (valid()) 
            {
                TextWriter dataSave = new StreamWriter(@"..\..\Intrebari\" + textBox6.Text + ".txt");
                foreach (string s in data)
                    dataSave.WriteLine(s);
                dataSave.Close();
            }

        }

        
    }
}
