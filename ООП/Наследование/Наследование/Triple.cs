using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Triple
    {
        // protected - делает доступным обращение к полям в классе наследнике
        protected int n1;
        protected int n2;
        protected int n3;
        public Triple(int n1, int n2, int n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        // virtual - помечаются методы, доступные для переопределения в классе наследнике
        public virtual string ToString()
        {
            return $"{n1} {n2} {n2}";
        }
    }
}
