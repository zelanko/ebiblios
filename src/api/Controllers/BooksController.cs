using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private Book[] _books = new Book[] { 
            new Book {
                Id = 1,
                Author = "Michael Crichton",
                Title = "Prey"
            },

            new Book {
                Id = 2,
                Author = "Gillian Flynn",
                Title =  "Gone Girl"
            }
        };
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return _books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            Book book = null;
            foreach (var b in _books) {
                if ( b != null && b.Id == id) {
                    book = b;
                }
            }
            return book;
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
