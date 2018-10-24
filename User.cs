using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LHBOL
{

    [Table("User")]
   public class User
    {
        [Key]
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        //1 User can submit many urls
        public IEnumerable<LHUrl> LHUrls { get; set; }
    }
}
