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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            TextReader dataLoad = new StreamReader(@"..\..\Info.txt");
            string buffer;
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                listBox1.Items.Add(buffer);
            }
        }
    }
}
