using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI_Git.DTO;
using MoviesAPI_Git.Repo;
using System.Net.Http.Headers;

namespace MoviesAPI_Git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private ICollection<Movie> _movies = MoviesRepo.movies;
        [HttpGet]
        public IActionResult getMovies()
        {
            return _movies == null ? BadRequest() : Ok(_movies);
        }
        [HttpPost]
        //[Route()]
        public IActionResult postMovies(Movie movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            _movies.Add(movie);
            return Created("v1/Movies", movie);
        }
        //You can also get things form whatever using the '[]' attrbiute, for example below I am getting the auth form header
        [HttpGet]
        [Route("secret")]
        public IActionResult getSecretMovie([FromHeader] string authorization)
        {
            //Example of how to get and work with Bearer Tokens
            IHeaderDictionary headers = Request.Headers;
            if (AuthenticationHeaderValue.TryParse(headers.Authorization, out var headerValue))
            {
                // we have a valid AuthenticationHeaderValue that has the following details:
                var scheme = headerValue.Scheme;
                var parameter = headerValue.Parameter;
                // scheme will be "Bearer"
                // parmameter will be the token itself.
            }
            return Ok("Good job");
        }

    }
}
