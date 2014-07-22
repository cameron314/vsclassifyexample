// Guids.cs
// MUST match guids.h
using System;

namespace moodycamel.HighlightDisposable
{
    static class GuidList
    {
        public const string guidHighlightDisposablePkgString = "bf2f0af4-2fcb-438a-81a6-25ca40db3feb";
        public const string guidHighlightDisposableCmdSetString = "ad0c2db7-bd27-4bc7-96bb-94971cc33d86";

        public static readonly Guid guidHighlightDisposableCmdSet = new Guid(guidHighlightDisposableCmdSetString);
    };
}