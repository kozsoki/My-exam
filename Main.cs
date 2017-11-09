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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Button[] T;
        int idx;
        int n;
        int idxrc;
        int punctaj;
        int crtq = 0;
 
        Panel gen = new Panel();
        public void setQuestion(Question obj) 
        {
            n = obj.raspunsuri.Count;
            label2.Text = obj.Domeniu;
            label4.Text = "";
            for (int i = 0; i < obj.nivel; i++)
                label4.Text += "*";
            label5.Text = obj.Titlu;
            listBox1.Items.Clear();
            foreach (string s in obj.continut)
                listBox1.Items.Add(s);
            label6.Visible = false;
            label6.Text = obj.Hint;


            gen.Controls.Clear();
            gen.Size = new Size(335, 150);
            gen.Parent = panel1;
            gen.Location = new Point(7, 185);
            gen.AutoScroll = false;
            gen.HorizontalScroll.Enabled = false;
            gen.HorizontalScroll.Visible = false;
            gen.HorizontalScroll.Maximum = 0;
            gen.AutoScroll = true;
            gen.BackColor = Color.LightBlue;
            T = new Button[obj.raspunsuri.Count];
            for (int i = 0; i < obj.raspunsuri.Count; i++)
            {
                T[i] = new Button();
                T[i].Text = obj.raspunsuri[i];
                T[i].Parent = gen;
                T[i].Size = new Size(315, 30);
                T[i].Location = new Point(10, 10 + i * 32);
                T[i].Name = i.ToString();
                T[i].Click += T_Click;
                T[i].BackColor = Color.LightGreen;
            }
            ACCEPT.Enabled = false;
            idxrc = obj.idrc;
            punctaj = obj.punctaj;
            label8.Text = "Punctaj= "+punctaj.ToString ();
            HINT_VIEW.Enabled = true;
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Imagini/" + obj.image.Trim());
            }
            catch { };
          
          
        }

        void T_Click(object sender, EventArgs e)
        {
            label7.Text = (sender as Button).Text;
            idx = int.Parse ((sender as Button).Name);
            for (int i = 0; i < n; i++)
            {
                T[i].BackColor = Color.LightGreen;
            }
            (sender as Button).BackColor = Color.Yellow;
            ACCEPT.Enabled = true;
        }

        Question crt;
        private void Form1_Load(object sender, EventArgs e)
        {
            crtq = 0;
            Engine.punctaj_total = 0;
            foreach (Question q in Engine.questions)
            {
                listBox2.Items.Add(q.shortData());
            }
            crt = Engine.questions[0];
            setQuestion(crt);
        }

        private void HINT_VIEW_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            punctaj /= 2;
            label8.Text ="Punctaj= " + punctaj.ToString ();
            HINT_VIEW.Enabled = false;
        }

        private void ACCEPT_Click(object sender, EventArgs e)
        {
            if (idx == idxrc)
            {
                MessageBox.Show("OK");
                Engine.punctaj_total += punctaj;
                label9.Text ="Total= " + Engine.punctaj_total.ToString();
            }
            crtq++;
            if (crtq == Engine.questions.Count)
            {
                MessageBox.Show("Game over! " + Engine.punctaj_total.ToString() + " punct ati optinut!");
                Application.Exit();
            }
            else
            {
                crt = Engine.questions[crtq];
                setQuestion(crt);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
