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
        private int idEmployee;
        private int index;
        private int idRequest;

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
        public string Description { get => description; set => description = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int Index { get => index; set => index = value; }
        public int IdRequest { get => idRequest; set => idRequest = value; }

        //Métodos

    }
}
