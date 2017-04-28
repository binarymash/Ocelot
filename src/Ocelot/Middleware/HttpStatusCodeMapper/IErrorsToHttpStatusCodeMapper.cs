using Ocelot.Responses;
using System.Collections.Generic;

namespace Ocelot.Middleware.HttpStatusCodeMapper
{
    /// <summary>
    /// Map a list OceoltErrors to a single appropriate HTTP status code
    /// </summary>
    public interface IErrorsToHttpStatusCodeMapper
    {
        int Map(List<Error> errors);
    }
}
