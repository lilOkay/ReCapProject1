﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorSevice
    {
        List<Color> GetAll();
        List<Color> GetById(int color_id);

        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
