﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.services
{
    public interface IUserService
    {
        string GetUserName(int id);
    }
}
