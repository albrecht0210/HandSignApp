using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandSignApp
{
    public class INeuron
    {
        private int id;
        private double value; // input
        private double[]? weights;

        public int Id { get => id; }
        public double Value { get => value; set => this.value = value; }
        public double[]? Weights { get => weights; }

        public INeuron()
        {
            this.id = 0;
            this.value = 0;
            this.weights = new double[64];
            this.SetInitWeight();
        }

        public INeuron(int id, int wsize)
        {
            this.id = id;
            this.value = 0;
            this.weights = new double[wsize];
            this.SetInitWeight();
        }

        private void SetInitWeight()
        {
            for (int i = 0; i < this.weights?.Length; i++)
                this.weights[i] = NetworkHelper.GetRandomNumber();
        }

        public void UpdateWeight(int hid, double err, double lrpin)
        {
            double product = lrpin * err * this.value;
            this.weights[hid] += product;
        }
    }
}
