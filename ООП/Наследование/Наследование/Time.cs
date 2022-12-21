using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Time : Triple
    {
        // Класс наследник обязательно должен вызывать базовый конструктор 
        public Time(int h, int m, int s) : base(h, m, s) { }
        public override string ToString()
        {
            return $"{n1}:{n2}:{n3}";
        }
    }
}
