using System.Collections.Generic;
using Ocelot.Middleware.DownstreamRouteFinder.UrlMatcher;
using Ocelot.Responses;
using Ocelot.Values;

namespace Ocelot.Middleware.DownstreamUrlCreator.UrlTemplateReplacer
{
    public interface IDownstreamPathPlaceholderReplacer
    {
        Response<DownstreamPath> Replace(PathTemplate downstreamPathTemplate, List<UrlPathPlaceholderNameAndValue> urlPathPlaceholderNameAndValues);   
    }
}