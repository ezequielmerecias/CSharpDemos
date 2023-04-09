using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demos
{
    public class ExpBodyMembers
    {
        public void Start()
        {
            
        }

    }

    public class Person
    {
        private int id;
        private static readonly Dictionary<int, string> names =
            new Dictionary<int, string>();

        public Person(int id, string name) => names.Add(id, name);
        ~Person() => names.Remove(id);

        public string Name
        {
            get => names[id];
            set => names[id] = value;
        }
    }
}
