// -----------------------------------------------------------------------
// <copyright file="ClusterKind.cs" company="Asynkron AB">
//      Copyright (C) 2015-2021 Asynkron AB All rights reserved
// </copyright>
// -----------------------------------------------------------------------
using System.Threading;

namespace Proto.Cluster
{
    public record ClusterKind(string Name, Props Props)
    {
        private int _count;

        public int Inc() => Interlocked.Increment(ref _count);
        public int Dec() => Interlocked.Decrement(ref _count);
    }
}