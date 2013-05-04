using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace CardCollection.Classes
{
    class NumberValidationRule : ValidationRule
    {
        public override ValidationResult Validate(
            object value, System.Globalization.CultureInfo cultureInfo)
        {
            string numberString;

            numberString = (string)value;

            // Makre sure our year is an actual number
            int number;
            try
            {
                number = Convert.ToInt32(numberString);
            }
            catch (FormatException fex)
            {
                return new ValidationResult(false,
                  "Numbers only please");
            }

            return ValidationResult.ValidResult;
        }
    }
}
