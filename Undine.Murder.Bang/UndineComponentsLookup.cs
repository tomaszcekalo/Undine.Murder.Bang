using Bang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Murder.Bang
{
    public class UndineComponentsLookup : ComponentsLookup
    {
        public void AddComponentType<A>()
        {
            ComponentsIndex.TryAdd(typeof(A), ComponentsIndex.Count);
        }
    }
}
