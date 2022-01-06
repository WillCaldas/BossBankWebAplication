﻿using BossBank.Data.Interfaces;
using BossBank.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}