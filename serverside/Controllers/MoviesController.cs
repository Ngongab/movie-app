using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using serverside.Models;

namespace serverside.Controllers
{
    [Route("api/")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMovieRepository repository;

        public object StatusCodes { get; private set; }

        public MoviesController(IMovieRepository repository)
        {
            this.repository = repository;
        }
        // GET api/values
        [HttpGet, Route("popular")]
        public async Task<MovieResult> GetMoviesAsync()
        {
            var movies = await repository.GetMoviesAsync();
            return movies;
        }

        // GET api/values/5
        [HttpGet, Route("{id}")]
        public async Task<ActionResult<Movie>> GetMovieAsync(int id)
        {
            var movie = await repository.GetMovieAsync(id);
            if (movie is null)
            {
                return NotFound();
            }
            return movie;
        }

        [HttpGet, Route("search")]
        public async Task<ActionResult<MovieResult>> SearchMovieAsync([FromQuery] string query)
        {
            try
            {
                var movies = await repository.SearchMovieAsync(query);

                if (movies != null)
                {
                    return Ok(movies);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500,
                    "Error retrieving data from the server");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
