using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            Engine.getAllQuestions();
            uniq_dom.Clear();
            foreach (Question q in Engine.all)
            {
                listBox1.Items.Add(q.shortData());
                all_dom.Add(q.Domeniu);
            }

            foreach (string s in all_dom)
            {
                bool ok = true;
                foreach (string a in uniq_dom)
                {
                    if (a == s)
                        ok = false;
                }
                if (ok)
                    uniq_dom.Add(s);
            }
            foreach (string s in uniq_dom)
                comboBox1.Items.Add(s);
            comboBox1.SelectedIndex = 0;
            ACCEPT.Enabled = false;
        }
        List<string> all_dom = new List<string>();
        List<string> uniq_dom = new List<string>();
        List<string> sele_dom = new List<string>();

        private void SELECT_DOMENIU_Click(object sender, EventArgs e)
        {

            bool ok = true;
            foreach (string s in listBox2.Items) 
            {
                if (uniq_dom[comboBox1.SelectedIndex] == s) ok = false;
            }
            if (ok)
                listBox2.Items.Add(uniq_dom[comboBox1.SelectedIndex]);
            else
            { MessageBox.Show("Data allready exist"); }

            verifica();
        }

        private void ACCEPT_Click(object sender, EventArgs e)
        {

            n = 0;
            Engine.selected.Clear();
            foreach (string s in listBox2.Items)
            {
                foreach (Question q in Engine.all)
                    if (q.Domeniu == s) { Engine.selected.Add(q); n++; }
            }

            Begin myBegin = new Begin();
            myBegin.ShowDialog();
        }

        private void SELECT_ALL_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (string s in uniq_dom)
                listBox2.Items.Add(s);
            verifica();
        
        }
        int n = 0;
        public void verifica() 
        {
            n = 0;
            Engine.selected.Clear ();
            foreach (string s in listBox2.Items)
            {
                foreach (Question q in Engine.all)
                    if (q.Domeniu == s) { Engine.selected.Add(q); n++; }
            }
            label2.Text = n.ToString();
            if (n != 0) ACCEPT.Enabled = true;
            else ACCEPT.Enabled = false;
        }

        private void REMOVE_ALL_Click(object sender, EventArgs e)
        {
            n = 0;
            Engine.selected.Clear();
            listBox2.Items.Clear();
            label2.Text = n.ToString();
            if (n != 0) ACCEPT.Enabled = true;
            else ACCEPT.Enabled = false;
        }

        private void RES_START_Click(object sender, EventArgs e)
        {
            Create myCreate = new Create();
            myCreate.ShowDialog();
        }

        private void INFO_START_Click(object sender, EventArgs e)
        {
            Info myInfo = new Info();
            myInfo.ShowDialog();
        }

    }
}
