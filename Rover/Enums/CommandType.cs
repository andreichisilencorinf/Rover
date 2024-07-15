using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMission.Enums
{
    internal enum CommandType
    {
        [Display(Name = "Left")]
        L,
        [Display(Name = "Right")]
        R,
        [Display(Name = "Move")]
        M
    }
}
