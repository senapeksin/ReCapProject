﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class ICarImageService
    {
        IResult Add(IFormFile file, NCarImage carImage);
        IResult Delete(NCarImage carImage);
        IResult Update(IFormFile file, NCarImage carImage);
        IDataResult<NCarImage> GetById(int id);
        IDataResult<List<NCarImage>> GetAll();
        IDataResult<List<NCarImage>> GetImagesByCarId(int id);
    }
}
