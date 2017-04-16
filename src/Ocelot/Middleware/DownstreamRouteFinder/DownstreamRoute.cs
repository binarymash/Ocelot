using System.Collections.Generic;
using Ocelot.Configuration;
using Ocelot.Middleware.DownstreamRouteFinder.UrlMatcher;

namespace Ocelot.Middleware.DownstreamRouteFinder
{
    public class DownstreamRoute
    {
        public DownstreamRoute(List<UrlPathPlaceholderNameAndValue> templatePlaceholderNameAndValues, ReRoute reRoute)
        {
            TemplatePlaceholderNameAndValues = templatePlaceholderNameAndValues;
            ReRoute = reRoute;
        }
        public List<UrlPathPlaceholderNameAndValue> TemplatePlaceholderNameAndValues { get; private set; }
        public ReRoute ReRoute { get; private set; }
    }
}