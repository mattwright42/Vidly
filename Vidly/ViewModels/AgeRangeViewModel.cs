using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class AgeRangeViewModel
    {

        private AgeRange _ageRange;

        public string ShortDescription
        {
            get
            {
                return _ageRange.ToString();
            }
        }

        public AgeRangeViewModel(AgeRange ageRange)
        {
            _ageRange = ageRange;
        }
    }
}