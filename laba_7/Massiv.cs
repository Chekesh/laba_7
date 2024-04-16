using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal class Massiv<T>
    {
        public T[] values;
        public Massiv(params T[] values) {
            this.values = values;
        }
        public void Add(T value)
        {
            var list = new List<T>(values);
            list.Add(value);
            values = list.ToArray();
            foreach (var item in values) {
                Console.WriteLine(item); 
            }
        }
        public void Remove(int index)
        {
            if (index > 0 || index <= values.Length)
            {
                var list = new List<T>(values);
                list.RemoveAt(index);
                values = list.ToArray();
            }
            else
            {
                Console.WriteLine("Такого индекса нет");
            }
            foreach (var item in values) {  Console.WriteLine(item); }
        }
        public T valueId(int index)
        {
            return values[index];
        }

        public int lenght()
        {
            return values.Length;
        }
    }
}
