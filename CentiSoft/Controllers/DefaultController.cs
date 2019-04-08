using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentiSoft.DAL;
using CentiSoft.DAL.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentiSoft.Controllers {
    [Route("api/[controller]/")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class DefaultController : ControllerBase {

        private readonly IRepository<Developer> developerRepository;

        public DefaultController(IRepository<Developer> developerRepository) {
            this.developerRepository = developerRepository;
        }
        // GET: api/Default
        //[EnableCors("AllowOrigin")]
        [HttpGet]
        public IEnumerable<Developer> Get() {
             return developerRepository.GetAll();

        }

        //[EnableCors("AllowOrigin")]
        [HttpPost]
        public Developer Post([FromForm]string name, [FromForm]string email) {
            Console.WriteLine(name + email);
            return developerRepository.Create(name, email);
        }



        // GET: api/Default/5
        //[EnableCors("AllowOrigin")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id) {
            return "value";
        }

        // POST: api/Default


        // PUT: api/Default/5
        [EnableCors("AllowOrigin")]
        [HttpPut("{id}")]
        public bool Put(int id, string name, string email) {
            return developerRepository.Update(id, name, email);
        }

        // DELETE: api/ApiWithActions/5
        [EnableCors("*")]
        [HttpDelete("{id}")]
        public int Delete([FromRoute] int id) {
            Console.WriteLine(id);
            return developerRepository.Delete(id);
        }
    }
}
