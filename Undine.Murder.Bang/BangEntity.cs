using Bang.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;

namespace Undine.Murder.Bang
{
    public class BangEntity : IUnifiedEntity
    {
        public Entity Entity { get; set; }

        public void AddComponent<A>(in A component) where A : struct
        {
            Entity.AddComponent(new BangComponentWrapper<A>()
            {
                value = component
            });
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref Entity.GetComponent<BangComponentWrapper<A>>().value;
        }

        public void RemoveComponent<A>() where A : struct
        {
            Entity.RemoveComponent<BangComponentWrapper<A>>();
        }
        public bool HasComponent<A>() where A : struct
        {
            return Entity.HasComponent<BangComponentWrapper<A>>();
        }
    }
}
