using Bang;
using Bang.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Murder.Bang
{
    public class UndineWorld : World
    {
        public UndineWorld(IList<(ISystem system, bool isActive)> systems ) : base(systems)
        {
        }
    }
}
