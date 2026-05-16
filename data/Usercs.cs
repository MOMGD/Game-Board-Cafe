using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;


namespace Event.Sql
{
    public class Usercs
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
