using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutsnuts
{
    public partial class valto : Form
    {
        public valto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = 0, mit = int.Parse(textBox1.Text),resz = 0;
                int mibe = int.Parse(comboBox1.Text);
                string keszlet = "0123456789ABCDEF", eredmeny = "";
                tmp = mit;
                while(tmp != 0)
                {
                    resz = tmp % mibe;
                    eredmeny = keszlet[resz] + eredmeny;
                    tmp = tmp / mibe;
                }
                textBox2.Text = eredmeny;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }
    }
}
