using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private FuncDelegate func;
        public SingleMission(FuncDelegate x, string name) {
            func += x;
            Name = name;
        }

        public string Name {get; }

        public string Type {  get { return "Single";  } }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value) {
            value = func(value);
            if (OnCalculate != null)
                OnCalculate(this, value);
            return value;
        }
    }
}
