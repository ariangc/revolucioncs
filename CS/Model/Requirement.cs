using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enumerators;

namespace Model
{
    public class Requirement
    {
        //atributos
        private RequirementType type;
        private string description;

        public Requirement(RequirementType type, string description)
        {
            this.type = type;
            this.description = description;
        }

        //getters y setters
        private RequirementType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        //Métodos
       
    }
}
