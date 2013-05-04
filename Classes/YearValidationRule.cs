using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace CardCollection.Classes
{
    class YearValidationRule : ValidationRule
    {
        public override ValidationResult Validate(
            object value, System.Globalization.CultureInfo cultureInfo)
        {
            string yearString;
            yearString = (string)value;

            // Need to handle a special case here, since I'm using a string
            // which stats off blank, this would instantly trigger a validation
            // error, so ignore that case and I will have to handle that situation
            // when I leave the first wizard page
            if (yearString != "")
            {
                // Makre sure our year is an actual number
                int year;
                try
                {
                    year = Convert.ToInt32(yearString);
                }
                catch (FormatException fex)
                {
                    return new ValidationResult(false,
                      "Invalid characters in year");
                }

                // Now make sure it falls within a reasonble range
                // (the first cigaret cards where printed in the the 1890's)
                DateTime currentDate = DateTime.Now;
                int currentYear = currentDate.Year;

                if (year < 1850 || year > currentYear)
                {
                    return new ValidationResult(false,
                      "Year out of range");
                }
            }

            return ValidationResult.ValidResult; // static valid result
        }
    }
}
