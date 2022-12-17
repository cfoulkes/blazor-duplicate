using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDuplicate.Api.Models;

public class ClientPerson : EntityBase
{
    public int PersonId { get; set; }
    public int ClientId { get; set; }
    public virtual Person Person { get; set; }
    public virtual Client Client { get; set; }
}
