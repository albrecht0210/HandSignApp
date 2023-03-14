using System.Diagnostics;
using System.Drawing;

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
            bias_file = project_path + "\\bias.csv";
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
            char[] letter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y' };
            int epoch = Convert.ToInt32(epoch_num_txt.Text);

            // CONVERT TRAINING DATA TO CSV
            /*using (StreamWriter csvWriter = new StreamWriter(dataset_directory + "/0Train/train.csv"))
            {
                int num = 1;
                int len_test = 1;
                int len = Directory.GetFiles(dataset_directory).Length;
                foreach (string file in Directory.GetFiles(dataset_directory))
                {
                    string[] filename_split = file.Split('\\');
                    string name_only = filename_split[filename_split.Length - 1].Split('.')[0];
                    Debug.WriteLine(num);
                    Debug.WriteLine("File: " + name_only + ", ");
                    for (int i = 0; i < letter.Length; i++)
                    {
                        if (name_only.Contains(letter[i]))
                        {
                            Debug.WriteLine("OUTPUT: " + i);
                            csvWriter.Write(i + ",");
                        }
                    }

                    Bitmap bm = new Bitmap(file);
                    for (int x = 0; x < bm.Height; x++)
                    {
                        for (int y = 0; y < bm.Width; y++)
                        {
                            int grayscale_intensity = bm.GetPixel(x, y).R;
                            csvWriter.Write(grayscale_intensity);

                            if ((y + (x * 28)) < 783)
                                csvWriter.Write(",");
                        }
                    }
                    if (len_test < (len))
                        csvWriter.WriteLine();
                    len_test++;
                    num++;
                }
            }*/

            for(int x = 0; x < epoch; x++)
            {
                Debug.WriteLine("Epoch: " + (x + 1));
                using (StreamReader csvReader = new StreamReader(dataset_directory + "/0Train/train.csv"))
                {
                    int len = 1;
                    while (!csvReader.EndOfStream)
                    {
                        Debug.WriteLine("Line: " + len);
                        string[] values = csvReader.ReadLine().Split(',');
                        int oid = Convert.ToInt32(values[0]);

                        for (int i = 1; i < values.Length; i++)
                            net.SetInputData((i - 1), Convert.ToDouble(values[i]));

                        for (int i = 0; i < letter.Length; i++)
                        {
                            if (oid == i)
                            {
                                Debug.WriteLine("Letter: " + letter[i]);
                                net.SetDesiredOutput(i, 1);
                            }
                            else
                                net.SetDesiredOutput(i, 0);
                        }
                        net.Learn();
                        len++;
                    }
                }
            }
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
            Debug.WriteLine(this.input_file);
            Bitmap bm = new Bitmap(this.input_file);
            for (int x = 0; x < bm.Height; x++)
            {
                for (int y = 0; y < bm.Width; y++)
                {
                    int grayscale_intensity = bm.GetPixel(x, y).R;
                    Debug.WriteLine((y + (x * 28)) + ": " + grayscale_intensity);
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