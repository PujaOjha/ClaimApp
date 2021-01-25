using System;
using System.Collections.Generic;
using Claim.ClaimService.Application.Service;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model = Claim.ClaimService.Application.Model;
using Microsoft.AspNetCore.Authorization;

namespace Claim.ClaimService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClaimsController : ControllerBase
    {
        public IClaimService claimService { get; }

        public ClaimsController(IClaimService claimService)
        {
            claimService = claimService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model.UserClaim>>> Get()
        {
            return await claimService.GetClaims();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Model.UserClaim>> Get(int id)
        {
            return await claimService.GetClaimByUser(id);
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] Model.UserClaim claim)
        {
             await claimService.CreateClaims(claim);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Model.UserClaim claim)
        {
            await claimService.UpdateClaims(claim);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await claimService.DeleteClaims(id);
        }
    }
}
