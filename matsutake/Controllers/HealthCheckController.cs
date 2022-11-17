using matsutake.Models;
using Microsoft.AspNetCore.Mvc;

namespace matsutake.Controllers
{
    public class HealthCheckController : Controller
    {
        public HealthCheckRespons HealthCheck()
        {
            HealthCheckRespons respons = new HealthCheckRespons();
            return respons;
        }
    }
}
