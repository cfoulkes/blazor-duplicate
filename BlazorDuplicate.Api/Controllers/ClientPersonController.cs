using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDuplicate.Api.Models;
using BlazorDuplicate.Api.Services;
using BlazorDuplicate.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDuplicate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientPersonController : ControllerBase
{
    private readonly ClientPersonService clientPersonService;
    private readonly IMapper mapper;

    public ClientPersonController(ClientPersonService clientPersonService, IMapper mapper)
    {
        this.clientPersonService = clientPersonService;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<ClientPersonDto>>> GetAllClientPersons()
    {
        try
        {
            var clientPersons = await clientPersonService.GetAllClientPersons();
            return Ok(mapper.Map<List<ClientPerson>, List<ClientPersonDto>>(clientPersons));
        }
        catch (Exception ex)
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                $"Error loading data: {ex.Message}"
            );
        }
    }

    // [HttpGet("{id:int}")]
    // public async Task<ActionResult<ProductDto>> GetItems(int id)
    // {
    //     try
    //     {
    //         var product = await productRepository.GetItem(id);

    //         if (product == null)
    //         {
    //             return NotFound();
    //         }

    //         var productCategory = await productRepository.GetCategory(product.CategoryId);

    //         return Ok(product.ConvertToDto(productCategory));
    //     }
    //     catch (Exception ex)
    //     {
    //         return StatusCode(
    //             StatusCodes.Status500InternalServerError,
    //             $"Error loading data: {ex.Message}"
    //         );
    //     }
    // }
}
