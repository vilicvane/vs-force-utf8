// Guids.cs
// MUST match guids.h
using System;

namespace VILICVANE.ForceUTF8
{
    static class GuidList
    {
        public const string guidForceUTF8PkgString = "7d93f986-94b0-43b8-8fb8-9477bf346ea1";
        public const string guidForceUTF8CmdSetString = "b998b6fb-ef9d-4250-9cde-ee9b515551b2";

        public static readonly Guid guidForceUTF8CmdSet = new Guid(guidForceUTF8CmdSetString);
    };
}