using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.Logging.Abstractions;

namespace FunctionBasicsTests
{
    public class WatchDetailsTest
    {
        [Fact]
        public void RunMethodShouldReturn200OnValidModel()
        {

            var req = new DefaultHttpRequest(new DefaultHttpContext())
            {
                Query = new QueryCollection(new Dictionary<string, StringValues>() { { "model", "hgf" } })
            };

            var logger = NullLoggerFactory.Instance.CreateLogger("Null Logger");

            var res = FunctionBasics.WatchDetails.Run(req, logger);

            res.Wait();

            Assert.IsAssignableFrom<OkObjectResult>(res.Result);




        }
    }
}
