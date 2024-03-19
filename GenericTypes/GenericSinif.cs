using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class GenericSinif<T>
    {
        public T ID { get; set; }//T tipinde verdik
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
