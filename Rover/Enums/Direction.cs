using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarsMission.Enums
{
    public enum Direction
    {
        [Display(Name = "North")]
        N,
        [Display(Name = "East")]
        E,
        [Display(Name = "South")]
        S,
        [Display(Name = "West")]
        W
    }
}
