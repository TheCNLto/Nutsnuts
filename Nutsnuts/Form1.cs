namespace Nutsnuts
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void doboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dobo dobo1 = new dobo();
            dobo1.Show();
        }

        private void átváltóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valto valto1 = new valto();
            valto1.Show();
        }
    }
}