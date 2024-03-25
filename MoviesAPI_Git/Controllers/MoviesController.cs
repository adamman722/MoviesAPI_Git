using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI_Git.DTO;
using MoviesAPI_Git.Repo;
using System.Net.Http.Headers;

namespace MoviesAPI_Git.Controllers
{
    /// <summary>
    /// Simple API to give movies to users.
    /// TODO: Figure out how to make this reset every 4 hours
    /// </summary>
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
        public IActionResult postMovies(MovieDTO movie)
        {

            if (movie == null)
            {
                return BadRequest();
            }
            
            Movie createdMovie = new Movie(movie);
            _movies.Add(createdMovie);
            return Created("v1/Movies", createdMovie);
        }

        //You can also get things form whatever using the '[]' attrbiute, for example below I am getting the auth form header
        [HttpGet]
        [Route("secret")]
        public IActionResult getSecretMovie()
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


                //This is with the token gen, hoping this works
                //I am sure there is a better way to conver to Guid but I will ask tomorrow.
                Guid guid = new Guid(parameter);
                if (TokenManager.ValidUser(guid))
                {                
                return Ok(MoviesRepo.secretMovie);
                }

            }

            return BadRequest("You may need to give some tokens to Bear.");
        }

    }
}
