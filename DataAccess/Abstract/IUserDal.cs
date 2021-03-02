using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<Core.Entities.Concrete.User>
    {
        List<OperationClaim> GetClaims(Core.Entities.Concrete.User user);
    }
}