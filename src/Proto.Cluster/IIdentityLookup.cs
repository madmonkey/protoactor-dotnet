// -----------------------------------------------------------------------
//   <copyright file="IClusterProvider.cs" company="Asynkron AB">
//       Copyright (C) 2015-2020 Asynkron AB All rights reserved
//   </copyright>
// -----------------------------------------------------------------------

using System.Threading;
using System.Threading.Tasks;
using Proto.Remote;

namespace Proto.Cluster.IdentityLookup
{
    public interface IIdentityLookup
    {
        Task<(PID?,ResponseStatusCode)> GetAsync(string identity,string kind, CancellationToken ct);
        void Setup(Cluster cluster, string[] kinds);
        void Stop();
    }
}