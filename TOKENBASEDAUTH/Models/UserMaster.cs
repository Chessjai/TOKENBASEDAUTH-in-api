using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TOKENBASEDAUTH.Models.DBclass
{
    [Table("UserMaster")]
    public class UserMaster
    {

        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRoles { get; set; }
        public string UserEmailID { get; set; }
    }
}