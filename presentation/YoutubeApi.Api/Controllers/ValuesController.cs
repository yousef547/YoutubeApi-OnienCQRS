using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Application.Interfaces.UnitOfWorks;
using YoutubeApi.Domain.Common.Entities;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork _UnitOfWork;
        public ValuesController(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
          return Ok(await this._UnitOfWork.GetReadRepository<Product>().GetAllAsync());
        }
    }
}
