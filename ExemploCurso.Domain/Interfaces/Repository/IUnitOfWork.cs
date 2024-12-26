﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCurso.Domain.Interfaces.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
