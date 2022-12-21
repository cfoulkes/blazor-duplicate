using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDuplicate.Api.Models;
using BlazorDuplicate.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDuplicate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientPersonController : ControllerBase
{
    private readonly ClientPersonService clientPersonService;

    public ClientPersonController(ClientPersonService clientPersonService)
    {
        this.clientPersonService = clientPersonService;
    }

    [HttpGet]
    public List<ClientPerson> GetAllClientPersons()
    {
        return null;
    }
}
