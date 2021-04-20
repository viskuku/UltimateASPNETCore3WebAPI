using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;

namespace UltimateASPNETCore3WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AisWebController : ControllerBase
    {

        private readonly IRepositoryManager _repositoryManager;

        public AisWebController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public async Task PegarNotamPorDataAsync()
        {
            await _repositoryManager.AisWeb.PegarNotamPorDataAsync(DateTime.Now);
        }
    }
}
