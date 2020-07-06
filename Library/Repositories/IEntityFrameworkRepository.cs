﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public interface IEntityFrameworkRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
