using Domain.Dtos.Customer;
using Domain.Interfaces.Services.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependentPersonController : ControllerBase
    {
        private IDependentPersonService _service;

        public DependentPersonController(IDependentPersonService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {//400
                return BadRequest(ModelState);
            }

            try
            {//200
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {//500
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        //[Authorize("Bearer")]
        [HttpGet]
        [Route("{id}", Name = "GetDependentPersonById")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }



        //[Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DependentPersonDtoCreate dependent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(dependent);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetDependentPersonById", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        //[Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] DependentPersonDtoUpdate dependent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(dependent);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


        //[Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}
