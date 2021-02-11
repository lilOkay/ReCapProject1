using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorSevice
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int color_id);

        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
