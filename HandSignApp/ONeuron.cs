using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandSignApp
{
    public class ONeuron
    {
        private int id;
        private double value; //activation
        private double bias;

        public int Id { get => id; }
        public double Value { get => value; set => this.value = value; }
        public double Bias { get => bias; set => bias = value; }

        public ONeuron()
        {
            this.id = 0;
            this.value = 0;
            this.bias = NetworkHelper.GetRandomNumber();
        }

        public ONeuron(int id)
        {
            this.id = id;
            this.value = 0;
            this.bias = NetworkHelper.GetRandomNumber();
        }
        public void UpdateBias(double lrpin, double[] err_der)
        {
            this.bias += lrpin * err_der[id];

        }
    }
}
