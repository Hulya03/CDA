using _01_Api_Rest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _01_Api_Rest.Models;


namespace _01_Api_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchatController : ControllerBase
    {
        private readonly AchatService _achatService;

        public AchatController(AchatService achatService)
        {
            _achatService = achatService;
        }

        [HttpGet]                           //corrrespond à l'opérateur Get de notre service
        public async Task<List<Achat>> Get()
        {
            return await _achatService.GetAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Achat>> Get(string _id)
        {
            Achat? result = await _achatService.GetAsync(_id);

            if(result is null )
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Achat newAchat)    //tache = loperation en cours 
                                                                 // <> : ce qu'il y a entre chevron, c'est ce que ca va retourné
        {
            await _achatService.CreateAsync(newAchat);          // await est relié au async  
                                                                // tout le code qui dépend de cette méthode est en attente 

            return CreatedAtAction(nameof(Get), new { id = newAchat.Id }, newAchat); 
        }


    }
}
