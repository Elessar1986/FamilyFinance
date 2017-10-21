using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFinance
{
    public class InOutCome
    {
        public int Id { get; set; }
        public string TypeName { get; set;}

        public InOutCome()
        {

        }

        public InOutCome(int id, string typename)
        {
            Id = id;
            TypeName = typename;
        }

        public override string ToString()
        {
            return $"{Id} : {TypeName}";
        }

    }
}
