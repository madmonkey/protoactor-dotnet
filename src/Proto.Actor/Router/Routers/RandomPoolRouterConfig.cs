// -----------------------------------------------------------------------
//   <copyright file="RandomPoolRouterConfig.cs" company="Asynkron AB">
//       Copyright (C) 2015-2020 Asynkron AB All rights reserved
//   </copyright>
// -----------------------------------------------------------------------
namespace Proto.Router.Routers
{
    class RandomPoolRouterConfig : PoolRouterConfig
    {
        private readonly ISenderContext _senderContext;
        private readonly int? _seed;

        public RandomPoolRouterConfig(ISenderContext senderContext, int poolSize, Props routeeProps, int? seed)
            : base(poolSize, routeeProps)
        {
            _senderContext = senderContext;
            _seed = seed;
        }

        public override RouterState CreateRouterState() => new RandomRouterState(_senderContext, _seed);
    }
}