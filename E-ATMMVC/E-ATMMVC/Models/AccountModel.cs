using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_ATMMVC.Models
{
    public class AccountModel
    {
            [Key]
            public int CardNumber { get; set; }
             public int PinNumber { get; set; }
            public int Balance{ get; set; }
    }
}