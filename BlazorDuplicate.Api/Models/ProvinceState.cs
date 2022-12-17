using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDuplicate.Api.Models;

public class ProvinceState : RefrenceTableBase
{
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }
}
