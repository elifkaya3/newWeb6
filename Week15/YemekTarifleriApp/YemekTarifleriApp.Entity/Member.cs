using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifleriApp.Entity
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string EMail { get; set; }
        public string MemberUserName { get; set; }
        public char MemberPassword { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
