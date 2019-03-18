using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List< FuncDelegate> Funcs = new List<FuncDelegate>();
        public string Name { get; }
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
   
        public string Type { get { return "Composed"; } }
        public object this [ string name]
        {
            get
            {
                return name;
            }

        }
        public ComposedMission(string name) {Name = name; }
        public  ComposedMission Add(FuncDelegate x)
        {
            Funcs.Add( x);
            return  this;
        }
        public double Calculate(double value)
        {
            foreach(var func in Funcs)
            {
                value = func(value);
            }
            if (OnCalculate != null)
                OnCalculate(this, value);
            return value;
        }

        
    }
}
