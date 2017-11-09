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
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void Begin_Load(object sender, EventArgs e)
        {
            foreach (Question q in Engine.selected)
                listBox1.Items.Add(q.shortData());
            numericUpDown1.Maximum = Engine.selected.Count;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = numericUpDown1.Maximum;
        }

 
        private void TEST_START_Click(object sender, EventArgs e)
        {
            Engine.questions.Clear();
            if (numericUpDown1.Value != numericUpDown1.Maximum)
            {
                Engine.selected.Sort(delegate(Question A, Question B) { return A.nivel.CompareTo(B.nivel); });
                if (trackBar1.Value == 0)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                        Engine.questions.Add(Engine.selected[i]);
                }
                else if (trackBar1.Value == 1)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int tmp = Engine.rnd.Next(Engine.selected.Count-1);
                        Engine.questions.Add(Engine.selected[tmp]);
                        Engine.selected.RemoveAt(tmp);
                    }
                }
                else 
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                        Engine.questions.Add(Engine.selected[Engine.selected.Count -1- i]);

                }

            }
            else
                Engine.questions = Engine.selected;
            Main myForm = new Main();
            myForm.ShowDialog();
            this.Close();

        }
    }


}
