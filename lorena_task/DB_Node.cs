using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lorena_task
{
    internal struct DB_Node
    {
        public DB_Node(int Id, string Name, int Discount, bool Dependence, int Parent_id, string Discription) { 
                this.Id = Id;
                this.Name = Name;
                this.Discount = Discount;
                this.Dependence = Dependence;
                this.Parent_id = Parent_id;
                this.Discription = Discription;
                childs = new List<DB_Node>();
        }
        public int Id;
        public string Name;
        public int Discount;
        public bool Dependence;
        public int Parent_id;
        public string Discription;
        public List<DB_Node> childs;
    }

}
