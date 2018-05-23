using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using static Utils.Enumerators;

namespace Model
{
    public class Request
    {
        //atributos
        public RequirementType type;
        private string description;
        private int type2;
        private int username;

        public Request()
        {
            this.description = null;
        }
        public Request(RequirementType type, string description)
        {
            this.Type = type;
            this.Description = description;
        }

        //getters y setters
        public RequirementType Type { get => type; set => type = value; }
        public int Type2 { get => type2; set => type2 = value; }
        public string Description { get => description; set => description = value; }
        public int Username { get => username; set => username = value; }

        //Métodos

    }
}
