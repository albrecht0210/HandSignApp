namespace HandSignApp
{
    public partial class Form1 : Form
    {
        private NeuralNetwork net;

        public Form1()
        {
            InitializeComponent();
        }

        private void create_model_btn_Click(object sender, EventArgs e)
        {
            int isize = Convert.ToInt32(ineuron_size_txt.Text);
            int hsize = Convert.ToInt32(hneuron_size_txt.Text);
            int osize = Convert.ToInt32(oneuron_size_txt.Text);
            int lrpin = Convert.ToInt32(ilearn_rate_txt.Text);
            int lrpout = Convert.ToInt32(olearn_rate_txt.Text);

            if (lrpin.Equals("") && lrpout.Equals(""))
                net = new NeuralNetwork(isize, hsize, osize);

            net = new NeuralNetwork(isize, hsize, osize, lrpin, lrpout);
        }

        private void train_btn_Click(object sender, EventArgs e)
        {
             
        }
    }
}