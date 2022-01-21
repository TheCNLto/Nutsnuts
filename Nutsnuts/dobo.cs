namespace Nutsnuts
{
    public partial class dobo : Form
    {
        static Random ran = new Random();
        public dobo()
        {
            InitializeComponent();
        }

        private void dododo_Click(object sender, EventArgs e)
        {
            dcount.Text = Convert.ToString(ran.Next(1, 6));
        }
    }
}
