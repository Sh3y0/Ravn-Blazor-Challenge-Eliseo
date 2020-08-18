using System;
using System.Linq;

namespace Ravn.Domain.Utilities
{
    public static class Utils
    {
        public static int getId(string _uri)
        {
            var uri = new Uri(_uri);
            var lastSegment = uri.Segments.Last();
            return int.Parse(lastSegment.Replace("/", "")); ;
        }
    }
}
