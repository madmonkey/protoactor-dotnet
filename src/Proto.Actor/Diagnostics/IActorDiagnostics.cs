// -----------------------------------------------------------------------
// <copyright file="IActorDiagnostics.cs" company="Asynkron AB">
//      Copyright (C) 2015-2022 Asynkron AB All rights reserved
// </copyright>
// -----------------------------------------------------------------------
namespace Proto.Diagnostics;

public interface IActorDiagnostics
{
    string GetDiagnosticsString();
}