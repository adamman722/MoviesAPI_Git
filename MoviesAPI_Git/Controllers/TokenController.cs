﻿using Microsoft.AspNetCore.Mvc;
using MoviesAPI_Git.Repo;
using MoviesAPI_Git.DTO;

namespace MoviesAPI_Git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        /// <summary>
        /// Gives you a token that lats for 10 minutes
        /// </summary>
        /// <returns> </returns>
        ///// <remarks>
        /////    <para>
        /////        This is an introductory paragraph.
        /////    </para>
        /////    <para>
        /////        This paragraph contains more details.
        /////    </para>
        /////</remarks>
        [HttpGet]
        public IActionResult GetToken()
        {
            var req = Request;
            TokenDTO tokenDTO = new TokenDTO();

            TokenManager.AddItem(tokenDTO, TimeSpan.FromSeconds(600));

            return Ok(tokenDTO.Id);
        }
    }
}
