﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImages>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).NotNull();
        }
    }
}
