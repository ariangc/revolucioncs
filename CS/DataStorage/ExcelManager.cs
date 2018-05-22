using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage{
    public class ExcelManager
    {

        private string fileName;

        public ExcelManager(string fileName)
        {
            this.fileName = fileName;
        }

        public string getFileName()
        {
            return fileName;
        }

        public void setFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public void insertEntity()
        {
            Console.WriteLine("Entidad insertada");
        }

        public void export()
        {
            Console.WriteLine("Exportada");
        }
    }
}
public class ExcelManager {
    
    private string fileName;

    public ExcelManager(string fileName) {
        this.fileName = fileName;
    }

    public string getFileName() {
        return fileName;
    }

    public void setFileName(string fileName) {
        this.fileName = fileName;
    }
    
    public void insertEntity() {
        Console.WriteLine("Entidad insertada");    
    }
    
    public void export() {
        Console.WriteLine("Exportada");    
    }
}