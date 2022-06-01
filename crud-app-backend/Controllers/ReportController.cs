using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using crud_app_backend.Contracts;
using crud_app_backend.Model;

namespace scholarship_backend.Controllers
{
    [Route("report")]
    [ApiController]
    public class ReportController:ControllerBase
    {
        private readonly IReport _reportrepo;
        public ReportController(IReport reportrepo)
        {
            _reportrepo = reportrepo;
        }
        [HttpGet]
        public async Task<IEnumerable<Report>> Read()
        {
            return await _reportrepo.Read();
        }
    }
}