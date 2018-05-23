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
        private RequirementType type;
        private string description;

        public Request()
        {

        }
        public Request(RequirementType type, string description)
        {
            this.Type = type;
            this.description = description;
        }

        //getters y setters

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

        public RequirementType Type { get => type; set => type = value; }

        //Métodos

    }
}
