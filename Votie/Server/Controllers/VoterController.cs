using Microsoft.AspNetCore.Mvc;
using Votie.Server.Services;
using Votie.Shared;

namespace Votie.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoterController : Controller
    {
        private readonly IDBOService _database;

        public VoterController(IDBOService database)
        {
            _database = database;
        }

        [HttpGet]
        public async Task<IEnumerable<Voter>> Get()
        {
            return await _database.ReadListAsync<Voter>($"SELECT * FROM voter");
        }

        [HttpGet("{id}")]
        public async Task<Voter?> Get(int id)
        {
            return await _database.ReadItemAsync<Voter?>($"SELECT * FROM voter WHERE Id = {id}");
        }

        [HttpPost]
        public async Task Create([FromBody] Voter voter)
        {
            await _database.ExecuteAsync($"INSERT into voter(name,lastname,date,document_id) values('{voter.Name}', '{voter.LastName}', '{voter.Date}','{voter.Document_id}')");
        }

        [HttpPut]
        public async Task Update([FromBody] Voter voter)
        {
            await _database.ExecuteAsync($"UPDATE voter set name = '{voter.Name}', lastname = '{voter.LastName}', date = '{voter.Date}', document_id ='{voter.Document_id}' WHERE Id = {voter.Id}");
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _database.ExecuteAsync($"DELETE FROM voter WHERE Id = {id}");
        }
    }
}
