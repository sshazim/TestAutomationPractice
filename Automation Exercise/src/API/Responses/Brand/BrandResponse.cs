using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationPractice.src.API.Responses.Brand
{
    public class BrandResponse
    {
        public HttpStatusCode ResponseCode { get; set; }
        public List<Brands> Brands { get; set; }
        public string? Message { get; set; }
    }
}
