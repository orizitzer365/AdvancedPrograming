using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double FuncDelegate(double p);
    public class FunctionsContainer
    {
 
        private Dictionary<string, FuncDelegate> map = new Dictionary<string,FuncDelegate >();
        public FuncDelegate this[string name]
        {
            get {
                if (map.ContainsKey(name))
                    return map[name];
                else
                {
                    map[name] = x => x;
                    return map[name];
                }
            }
            set
            {
                map[name] = value;
            }
        }
        public void PrintMissions()
        {
            Console.WriteLine("All Available Functions:");
            foreach (var key in map.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("####################################");
        }
        public List<string> getAllMissions()
        {
            return map.Keys.ToList();
        }


    }
}
