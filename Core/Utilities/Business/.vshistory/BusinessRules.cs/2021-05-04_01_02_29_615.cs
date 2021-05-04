﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
   public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success == true)

                {
                    return logic;
                }
            }


            return null;
        }

    }
}
