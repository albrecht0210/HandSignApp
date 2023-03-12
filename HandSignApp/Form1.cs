using System.Diagnostics;

namespace HandSignApp
{
    public partial class Form1 : Form
    {
        private readonly string project_path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;
        private NeuralNetwork net;
        private string dataset_directory = "D:\\Projects\\Dataset\\Train";
        private string weights_file;
        private string bias_file;
        private string input_file;

        public Form1()
        {
            InitializeComponent();
            weights_file = project_path + "\\weights.csv";
            weights_file = project_path + "\\bias.csv";
        }

        private void create_model_btn_Click(object sender, EventArgs e)
        {
            int isize = 784;
            int hsize = Convert.ToInt32(hneuron_size_txt.Text);
            int osize = 24;
            double lrpin = Convert.ToDouble(ilearn_rate_txt.Text);
            double lrpout = Convert.ToDouble(olearn_rate_txt.Text);

            if (lrpin.Equals("") && lrpout.Equals(""))
                net = new NeuralNetwork(isize, hsize, osize);

            net = new NeuralNetwork(isize, hsize, osize, lrpin, lrpout);

            Debug.WriteLine(project_path);
        }

        private void train_btn_Click(object sender, EventArgs e)
        {
            int epoch = Convert.ToInt32(epoch_num_txt.Text);

            foreach (string sub_directory in Directory.GetDirectories(dataset_directory))
            {
                Debug.WriteLine(sub_directory);
                using (StreamWriter csvWriter = new StreamWriter(sub_directory + "/" + Path.GetFileName(sub_directory) + ".csv"))
                {
                    int len_test = 1;
                    int len = Directory.GetFiles(sub_directory).Length;
                    foreach (string file in Directory.GetFiles(sub_directory))
                    {
                        if (file == (sub_directory + "\\" + Path.GetFileName(sub_directory) + ".csv"))
                            break;
                        Debug.WriteLine(file);

                        Bitmap bm = new Bitmap(file);
                        for (int x = 0; x < bm.Height; x++)
                        {
                            for (int y = 0; y < bm.Width; y++)
                            {
                                int grayscale_intensity = bm.GetPixel(x, y).R;
                                csvWriter.Write(grayscale_intensity);

                                if((y + (x * 28)) < 783)
                                    csvWriter.Write(",");
                            }
                        }
                        if(len_test < (len - 1))
                            csvWriter.WriteLine();
                        len_test++;
                    }
                }
            }

            /*for (int i = 1; i <= epoch; i++)
            {
                Debug.WriteLine("Epoch: " + i);
                int letter_num = 0;
                foreach (string sub_directory in Directory.GetDirectories(dataset_directory))
                {
                    foreach (string file in Directory.GetFiles(sub_directory))
                    {
                        Bitmap bm = new Bitmap(file);
                        for (int x = 0; x < bm.Height; x++)
                        {
                            for (int y = 0; y < bm.Width; y++)
                            {
                                int grayscale_intensity = bm.GetPixel(x, y).R;

                                net.SetInputData(y + (x * 28), grayscale_intensity);
                            }
                        }

                        for (int x = 0; x < 24; x++)
                        {
                            if (x == letter_num)
                                net.SetDesiredOutput(x, 1);
                            else
                                net.SetDesiredOutput(x, 0);
                        }
                        net.Learn();
                    }
                    letter_num++;
                }
            }*/

            //string letter = alphabet_box.SelectedItem.ToString();
            /*using (StreamReader rd = new StreamReader(filepath_dataset))
            {
                string line = rd.ReadLine();
                MessageBox.Show(line);
            }*/
        }

        private void input_image_btn_Click(object sender, EventArgs e)
        {
            if (input_image_dialog.ShowDialog() == DialogResult.OK)
            {
                this.input_file = input_image_dialog.FileName;

                Bitmap bm = new Bitmap(new Bitmap(this.input_file), new Size(150, 150));
                bm.SetResolution(96, 96);

                Image rImage = Image.FromHbitmap(bm.GetHbitmap());

                image_display.Image = rImage;
            }
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(this.input_file);
            for (int x = 0; x < bm.Height; x++)
            {
                for (int y = 0; y < bm.Width; y++)
                {
                    int grayscale_intensity = bm.GetPixel(x, y).R;

                    net.SetInputData(y + (x * 28), grayscale_intensity);
                }
            }
            net.Run();

            string result = "";
            for (int i = 0; i < 24; i++)
                result += "Output[" + (i + 1) + "]: " + net.GetOutputData(i) + "\n";

            MessageBox.Show(result);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            net.Save(weights_file, bias_file);
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            net.Load(weights_file, bias_file);
        }
    }
}