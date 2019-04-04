using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentiSoft.DAL;
using CentiSoft.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentiSoft.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase {

        private readonly IRepository<Developer> developerRepository;

        public DefaultController(IRepository<Developer> developerRepository) {
            this.developerRepository = developerRepository;
        }
        // GET: api/Default
        [HttpGet]
        public IEnumerable<Developer> Get() {
             return developerRepository.GetAll();

        }

        [HttpPost]
        public Developer Post(string name, string email) {
            Console.WriteLine("lkamsd");
            return developerRepository.Create(name, email);
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id) {
            return "value";
        }

        // POST: api/Default


        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
