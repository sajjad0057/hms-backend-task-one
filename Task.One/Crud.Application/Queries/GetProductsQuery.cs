﻿using Crud.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Queries
{
    public sealed record GetProductsQuery : IRequest<IList<ProductDto>>;
}
