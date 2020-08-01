using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SwashbuckleNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Cria um item.
        /// </summary>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "nome": "Item1"
        ///     }
        ///
        /// </remarks>
        /// <param name="value"></param>
        /// <returns>Um item recém-criado</returns>
        /// <response code="201">Retorna o item recém-criado</response>
        /// <response code="400">Se o item for nulo</response> 
        // POST api/values        
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Excluir um item específico.
        /// </summary>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}