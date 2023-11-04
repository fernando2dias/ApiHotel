using System.Net;
using Api.Domain.Entities;
using Domain.Dtos.Customer;
using Domain.Interfaces.Services.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private ICustomerService _service;
    public CustomersController(ICustomerService service)
    {
        _service = service;
    }

    //[Authorize("Bearer")]
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
    [Route("{id}", Name = "GetById")]
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
    public async Task<ActionResult> Post([FromBody] CustomerDtoCreate customer)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _service.Post(customer);
            if (result != null)
            {
                return Created(new Uri(Url.Link("GetById", new { id = result.Id })), result);
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
    public async Task<ActionResult> Put([FromBody] CustomerDtoUpdate customer)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _service.Put(customer);
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