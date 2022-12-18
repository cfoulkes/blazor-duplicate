using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDuplicate.Api.Repositories

public class ClientPersonRepository
{
    private readonly DataContext context;

    public ClientPersonRepository(DataContext context)
    {
            this.context = context;
    }
}
