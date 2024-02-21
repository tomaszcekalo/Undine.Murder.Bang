using Bang.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Murder.Bang
{
    public class BangComponentWrapper<T> : IComponent where T : struct
    {
        public T value;
    }
}
