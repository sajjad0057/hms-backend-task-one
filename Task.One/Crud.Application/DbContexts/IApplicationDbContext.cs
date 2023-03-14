using Crud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
    }
}
