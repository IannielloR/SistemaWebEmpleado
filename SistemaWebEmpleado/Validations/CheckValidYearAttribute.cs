﻿using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class CheckValidYearAttribute:ValidationAttribute
    {
        public CheckValidYearAttribute()
        {
            ErrorMessage = "El año debe ser mayor o igual a 1598";
        }
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 2000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
