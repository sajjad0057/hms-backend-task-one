﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Application.Commands
{
    public sealed record RemoveProductByIdCommand(Guid id) : IRequest;
}
