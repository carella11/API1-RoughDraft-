using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Controllers.Folder1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Song> GetOne(int id)
        {
            return await Task.Run(()=>
            new Song() { Id = id, Artist = "Flume", Name = "Ezra"}
            );
        }
        [HttpGet]
        public async Task<IEnumerable<Song>> GetMany()
        {
            return await Task.Run(() => new[]
            {
                new Song() { Id = 1, Artist = "J Cole", Name = "Lights Please" },
                new Song() { Id = 2, Artist = "Kojey Radical", Name = "Water" }
            }
                    );
        }
        [HttpPost]
        public async Task<int> Create(Song song)
        {
            return await Task.Run(() => 1);
        }
        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }
    }
}
