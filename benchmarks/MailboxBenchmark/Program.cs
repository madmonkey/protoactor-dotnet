﻿// -----------------------------------------------------------------------
//  <copyright file="Program.cs" company="Asynkron AB">
//      Copyright (C) 2015-2020 Asynkron AB All rights reserved
//  </copyright>
// -----------------------------------------------------------------------

using BenchmarkDotNet.Running;

class Program
{
    static void Main() => BenchmarkRunner.Run<MailboxBenchmark>();
}