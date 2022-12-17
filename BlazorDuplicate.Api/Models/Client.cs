using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDuplicate.Api.Models;

public class Client : EntityBase
{
    public int ClientTypeId { get; set; }
    public virtual ClientType ClientType { get; set; }
}

