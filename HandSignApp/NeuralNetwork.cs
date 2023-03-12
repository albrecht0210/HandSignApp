using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandSignApp
{
    public class NeuralNetwork
    {
        private INeuron[] ineuron;
        private HNeuron[] hneuron;
        private ONeuron[] oneuron;
        private double[] desired_output;
        private double lrpin;
        private double lrpout;
        private double[] err_component;
        private double[] err_derivative;

        public INeuron[] Ineuron { get => ineuron; }
        public HNeuron[] Hneuron { get => hneuron; }
        public ONeuron[] Oneuron { get => oneuron; }
        public double[] Desired_output { get => desired_output; set => desired_output = value; }
        public double Lrpin { get => lrpin; set => lrpin = value; }
        public double Lrpout { get => lrpout; set => lrpout = value; }
        public double[] Err_component { get => err_component; }
        public double[] Err_derivative { get => err_derivative; }

        public NeuralNetwork()
        {
            ineuron = new INeuron[3072];
            hneuron = new HNeuron[64];
            oneuron = new ONeuron[10];
            desired_output = new double[10];
            this.lrpin = 0.2;
            this.lrpout = 0.15;
            err_component = new double[10];
            err_derivative = new double[10];
            this.CreateNeurons();
        }

        public NeuralNetwork(double lrpin = 0.2, double lrpout = 0.15)
        {
            ineuron = new INeuron[3072];
            hneuron = new HNeuron[64];
            oneuron = new ONeuron[10];
            desired_output = new double[10];
            this.lrpin = lrpin;
            this.lrpout = lrpout;
            err_component = new double[10];
            err_derivative = new double[10];
            this.CreateNeurons();
        }

        public NeuralNetwork(int input, int hidden, int output)
        {
            ineuron = new INeuron[input];
            hneuron = new HNeuron[hidden];
            oneuron = new ONeuron[output];
            desired_output = new double[output];
            this.lrpin = 0.2;
            this.lrpout = 0.15;
            err_component = new double[output];
            err_derivative = new double[output];
            this.CreateNeurons();
        }

        public NeuralNetwork(int input, int hidden, int output, double lrpin = 0.2, double lrpout = 0.15)
        {
            ineuron = new INeuron[input];
            hneuron = new HNeuron[hidden];
            oneuron = new ONeuron[output];
            desired_output = new double[output];
            this.lrpin = lrpin;
            this.lrpout = lrpout;
            err_component = new double[output];
            err_derivative = new double[output];
            this.CreateNeurons();
        }

        private void CreateNeurons()
        {
            for (int x = 0; x < ineuron.Length; x++)
                ineuron[x] = new INeuron(x, hneuron.Length);

            for (int h = 0; h < hneuron.Length; h++)
                hneuron[h] = new HNeuron(h, oneuron.Length);

            for (int o = 0; o < oneuron.Length; o++)
                oneuron[o] = new ONeuron(o);
        }

        public void SetInputData(int id, double data)
        {
            ineuron[id].Value = data;
        }

        public void SetDesiredOutput(int id, double data)
        {
            desired_output[id] = data;
        }

        public double GetOutputData(int id)
        {
            return oneuron[id].Value;
        }

        private double Sigmoid(double data)
        {
            //if (data >= 20.00)
            //    data = 32;
            return 1 / (1 + Math.Exp(-data)); 
        }

        private void CalcHActivation()
        {
            for (int h = 0; h < hneuron.Length; h++)
            {
                double activation = 0;
                for (int x = 0; x < ineuron.Length; x++)
                    activation += ineuron[x].Value * ineuron[x].Weights[h];
                activation += hneuron[h].Bias;

                hneuron[h].Value = Sigmoid(activation);
            }
        }

        private void CalcOActivation()
        {
            for (int o = 0; o < oneuron.Length; o++)
            {
                double activation = 0;
                for (int h = 0; h < hneuron.Length; h++)
                    activation += hneuron[h].Value * hneuron[h].Weights[o];
                activation += oneuron[o].Bias;

                oneuron[o].Value = Sigmoid(activation);
            }
        }

        private void CalcErrComponent()
        {
            for (int o = 0; o < oneuron.Length; o++)
                err_component[o] = desired_output[o] - oneuron[o].Value;
        }

        private void CalcErrDerivative()
        {
            for (int o = 0; o < oneuron.Length; o++)
                err_derivative[o] = (1 - oneuron[o].Value) * oneuron[o].Value * err_component[o];
        }

        public void Run()
        {
            this.CalcHActivation();
            this.CalcOActivation();
        }

        public void Learn()
        {
            this.Run();
            this.CalcErrComponent();
            this.CalcErrDerivative();

            for (int h = 0; h < hneuron.Length; h++)
                hneuron[h].CalcErr(err_derivative);

            for (int h = 0; h < hneuron.Length; h++)
                hneuron[h].UpdateWeight(lrpout, err_derivative);

            for (int x = 0; x < ineuron.Length; x++)
                for (int h = 0; h < hneuron.Length; h++)
                    ineuron[x].UpdateWeight(h, hneuron[h].Err, lrpin);

            for (int o = 0; o < oneuron.Length; o++)
                oneuron[o].UpdateBias(lrpin, err_derivative);

            for (int h = 0; h < hneuron.Length; h++)
                hneuron[h].UpdateBias(lrpin);
        }
        public void Save(string weight_file, string bias_file)
        {
            this.SaveWeights(weight_file);
            this.SaveBias(bias_file);
        }

        public void SaveWeights(string filepath)
        {
            using (StreamWriter stream = new StreamWriter(filepath))
            {
                for (int x = 0; x < ineuron.Length; x++)
                {
                    for (int h = 0; h < hneuron.Length; h++)
                        stream.Write(ineuron[x].Weights[h] + ",");
                    stream.WriteLine();
                }

                for (int h = 0; h < hneuron.Length; h++)
                {
                    for (int o = 0; o < oneuron.Length; o++)
                        stream.Write(hneuron[h].Weights[o] + ",");
                    stream.WriteLine();
                }
            }
        }

        public void SaveBias(string filepath)
        {
            using (StreamWriter stream = new StreamWriter(filepath))
            {
                for (int h = 0; h < hneuron.Length; h++)
                    stream.Write(hneuron[h].Bias + ",");

                stream.WriteLine();

                for (int o = 0; o < oneuron.Length; o++)
                    stream.Write(oneuron[o].Bias + ",");
            }
        }

        public void Load(string weight_file, string bias_file)
        {
            this.LoadWeights(weight_file);
            this.LoadBias(bias_file);
        }

        public void LoadWeights(string filepath)
        {
            using (StreamReader stream = new StreamReader(filepath))
            {
                for (int x = 0; x < ineuron.Length; x++)
                {
                    string[] val = stream.ReadLine().Split(',');
                    for (int h = 0; h < hneuron.Length; h++)
                        ineuron[x].Weights[h] = Convert.ToDouble(val[h]);
                }

                for (int h = 0; h < hneuron.Length; h++)
                {
                    string[] val = stream.ReadLine().Split(',');
                    for (int o = 0; o < oneuron.Length; o++)
                        hneuron[h].Weights[o] = Convert.ToDouble(val[o]);
                }
            }
        }

        public void LoadBias(string filepath)
        {
            using (StreamReader stream = new StreamReader(filepath))
            {
                string[] val = stream.ReadLine().Split(',');
                for (int h = 0; h < hneuron.Length; h++)
                    hneuron[h].Bias = Convert.ToDouble(val[h]);

                val = stream.ReadLine().Split(',');
                for (int o = 0; o < oneuron.Length; o++)
                    oneuron[o].Bias = Convert.ToDouble(val[o]);
            }
        }
    }
}
