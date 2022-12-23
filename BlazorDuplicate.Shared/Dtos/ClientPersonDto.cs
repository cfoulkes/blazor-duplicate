using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDuplicate.Shared.Dtos;

public class ClientPersonDto
{
    public int Id { get; set; }
    public PersonDto Person { get; set; }
}
