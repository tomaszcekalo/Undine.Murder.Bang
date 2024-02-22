using Bang;
using Bang.Contexts;
using Bang.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Murder.Bang
{
    public abstract class BangSystem : IRenderSystem
    {
        public World World { get; set; }
        public Type[] Types { get; set; }
    }
    public class BangSystem<A> : BangSystem, IUpdateSystem, Core.ISystem
        where A : struct
    {
        public Core.UnifiedSystem<A> System { get; set; }

        public BangSystem()
        {
            Types = new Type[]
            {
                typeof(BangComponentWrapper<A>)
            };
        }
        public void ProcessAll()
        {
            var entities=this.World.GetEntitiesWith(ContextAccessorFilter.AllOf, Types);
            foreach(var entity in entities)
            {
                System.ProcessSingleEntity(
                    entity.EntityId,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value
                    );
            }
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

    public class BangSystem<A, B> : BangSystem, IUpdateSystem, Core.ISystem
        where A : struct
        where B : struct
    {
        public Core.UnifiedSystem<A, B> System { get; set; }

        public BangSystem()
        {
            Types = new Type[]
            {
                typeof(BangComponentWrapper<A>),
                typeof(BangComponentWrapper<B>)
            };
        }
        public void ProcessAll()
        {
            var entities = this.World.GetEntitiesWith(ContextAccessorFilter.AllOf, Types);
            foreach (var entity in entities)
            {
                System.ProcessSingleEntity(
                    entity.EntityId,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value,
                    ref entity.GetComponent<BangComponentWrapper<B>>().value
                    );
            }
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
    public class BangSystem<A, B, C> : BangSystem, IUpdateSystem, Core.ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public Core.UnifiedSystem<A, B, C> System { get; set; }

        public BangSystem()
        {
            Types = new Type[]
            {
                typeof(BangComponentWrapper<A>),
                typeof(BangComponentWrapper<B>),
                typeof(BangComponentWrapper<C>)
            };
        }
        public void ProcessAll()
        {
            var entities = this.World.GetEntitiesWith(ContextAccessorFilter.AllOf, Types);
            foreach (var entity in entities)
            {
                System.ProcessSingleEntity(
                    entity.EntityId,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value,
                    ref entity.GetComponent<BangComponentWrapper<B>>().value,
                    ref entity.GetComponent<BangComponentWrapper<C>>().value
                    );
            }
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
    public class BangSystem<A, B, C, D> : BangSystem, IUpdateSystem, Core.ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public Core.UnifiedSystem<A, B, C, D> System { get; set; }

        public BangSystem()
        {
            Types = new Type[]
            {
                typeof(BangComponentWrapper<A>),
                typeof(BangComponentWrapper<B>),
                typeof(BangComponentWrapper<C>),
                typeof(BangComponentWrapper<D>)
            };
        }
        public void ProcessAll()
        {
            var entities = this.World.GetEntitiesWith(ContextAccessorFilter.AllOf, Types);
            foreach (var entity in entities)
            {
                System.ProcessSingleEntity(
                    entity.EntityId,
                    ref entity.GetComponent<BangComponentWrapper<A>>().value,
                    ref entity.GetComponent<BangComponentWrapper<B>>().value,
                    ref entity.GetComponent<BangComponentWrapper<C>>().value,
                    ref entity.GetComponent<BangComponentWrapper<D>>().value
                    );
            }
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
