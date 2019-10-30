using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class AgeRange
    {
        public Range Range { get; set; }
    }

    public enum Range
    {
        Preschool,
        LittleKid,
        BigKid,
        Tween,
        Teen
    }
}