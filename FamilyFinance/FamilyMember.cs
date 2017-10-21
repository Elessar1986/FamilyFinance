using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFinance
{
    public class FamilyMember
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FamilyMember() { }
        public FamilyMember(string F,string L, int Id = 0)
        {
            MemberId = Id;
            FirstName = F;
            LastName = L;
        }
    }
}
