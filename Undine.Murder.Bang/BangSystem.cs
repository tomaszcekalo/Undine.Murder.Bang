using Bang.Contexts;
using Bang.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Murder.Bang
{
    public class BangRenderSystem : IRenderSystem
    {

    }
    public class BangSystem<A> : IUpdateSystem, Core.ISystem
        where A : struct
    {
        public Core.UnifiedSystem<A> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Context context)
        {
            foreach (var entity in context.Entities)
            {
                System.ProcessSingleEntity(0,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value);
            }
        }
    }

    public class BangSystem<A, B> : IUpdateSystem, Core.ISystem
        where A : struct
        where B : struct
    {
        public Core.UnifiedSystem<A, B> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Context context) 
        {
            foreach(var entity in context.Entities)
            {
                System.ProcessSingleEntity(0, 
                    ref entity.GetComponent<BangComponentWrapper<A>>().value, 
                    ref entity.GetComponent<BangComponentWrapper<B>>().value);
            }
        }
    }
    public class BangSystem<A, B, C> : IUpdateSystem, Core.ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public Core.UnifiedSystem<A, B, C> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Context context)
        {
            foreach (var entity in context.Entities)
            {
                System.ProcessSingleEntity(0,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value,
                    ref entity.GetComponent<BangComponentWrapper<B>>().value,
                    ref entity.GetComponent<BangComponentWrapper<C>>().value);
            }
        }
    }
    public class BangSystem<A, B, C, D> : IUpdateSystem, Core.ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public Core.UnifiedSystem<A, B, C, D> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Context context)
        {
            foreach (var entity in context.Entities)
            {
                System.ProcessSingleEntity(0,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value,
                    ref entity.GetComponent<BangComponentWrapper<B>>().value,
                    ref entity.GetComponent<BangComponentWrapper<C>>().value,
                    ref entity.GetComponent<BangComponentWrapper<D>>().value);
            }
        }
    }
}
