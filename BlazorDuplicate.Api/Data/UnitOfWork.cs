using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDuplicate.Api.Data;

public class UnitOfWork
{
    private readonly DataContext context;

    public UnitOfWork(DataContext context)
    {
        this.context = context;
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}
