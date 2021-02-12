﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService:IBaseService<User>
    {
        DataResult<User> GetByEmail(string email);
    }
}