using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Date : Triple
    {
        public Date(int d, int m, int y) : base(d, m, y) { }

        // override - переопределение базового метода
        public override string ToString()
        {
            return $"{n1}.{n2}.{n3}";
        }
    }
}
