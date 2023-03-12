using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandSignApp
{
    public class HNeuron
    {
        private int id;
        private double value; //activation
        private double[]? weights;
        private double bias;
        private double err;

        public int Id { get => id; }
        public double Value { get => value; set => this.value = value; }
        public double[]? Weights { get => weights; }
        public double Bias { get => bias; set => bias = value; }
        public double Err { get => err; set => err = value; }

        public HNeuron()
        {
            this.id = 0;
            this.value = 0;
            this.weights = new double[10];
            this.bias = NetworkHelper.GetRandomNumber();
            this.err = 0;
            this.SetInitWeight();
        }

        public HNeuron(int id, int wsize)
        {
            this.id = id;
            this.value = 0;
            this.weights = new double[wsize];
            this.bias = NetworkHelper.GetRandomNumber();
            this.err = 0;
            this.SetInitWeight();
        }

        private void SetInitWeight()
        {
            for (int i = 0; i < this.weights?.Length; i++)
                this.weights[i] = NetworkHelper.GetRandomNumber();
        }

        public void CalcErr(double[] err_der)
        {
            double total = 0;
            for (int i = 0; i < err_der.Length; i++)
                total += (err_der[i] * this.weights[i]);
            this.err = (1 - this.value) * this.value * total;
        }

        public void UpdateWeight(double lrpout, double[] err_der)
        {
            double product = this.value * lrpout;
            for (int i = 0; i < err_der.Length; i++)
                this.weights[i] += (product * err_der[i]);
        }

        public void UpdateBias(double lrpin)
        {
            this.bias += (-lrpin * this.err);
        }
    }
}
