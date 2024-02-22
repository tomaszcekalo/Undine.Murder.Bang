using Bang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;

namespace Undine.Murder.Bang
{
    public class BangContainer : EcsContainer
    {
        public World World { get; set; }
        public List<(global::Bang.Systems.ISystem system, bool isActive)> Systems { get; set; }
        public UndineComponentsLookup Lookup { get; set; }
        List<BangSystem> SystemsToInitialize { get; set; }

        public BangContainer()
        {
            Systems = new List<(global::Bang.Systems.ISystem system, bool isActive)>();
            Lookup = new UndineComponentsLookup();
            SystemsToInitialize = new();
        }
        public override void RegisterComponentType<A>(Action<object, IUnifiedEntity> action = null)
        {
            base.RegisterComponentType<A>(action);
            Lookup.AddComponentType<A>();
        }
        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            Systems.Add((new BangSystem<A>()
            {
                System = system,
            }, true));
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            Systems.Add((new BangSystem<A, B>()
            {
                System = system,
            }, true));
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            Systems.Add((new BangSystem<A, B, C>()
            {
                System = system,
            }, true));
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            Systems.Add((new BangSystem<A, B, C, D>()
            {
                System = system,
            }, true));
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new BangEntity()
            {
                Entity = World.AddEntity()
            };
        }

        public override void DeleteEntity(IUnifiedEntity entity)
        {
            var entityToDestroy = entity as BangEntity;
            if (entityToDestroy is not null)
            {
                entityToDestroy.Entity.Destroy();
            }
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            var result= new BangSystem<A>()
            {
                System = system,
            };
            SystemsToInitialize.Add(result);
            return result;
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            var result = new BangSystem<A, B>()
            {
                System = system,
            };
            SystemsToInitialize.Add(result);
            return result;
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            var result = new BangSystem<A, B, C>()
            {
                System = system,
            };
            SystemsToInitialize.Add(result);
            return result;
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            var result = new BangSystem<A, B, C, D>()
            {
                System = system,
            };
            SystemsToInitialize.Add(result);
            return result;
        }

        public override void Run()
        {
            World.Update();
        }

        public override void Init()
        {
            base.Init();
            this.World = new World(this.Systems);
            foreach(var system in SystemsToInitialize)
            {
                system.World = this.World;
            }
        }
    }
}