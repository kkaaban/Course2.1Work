using EntitiesDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDAL
{
    public class ServiceDeclarationDAL
    {
        public ServiceDeclarationDAL(string path)
        {
            this.path = path;
        }
        string path;
        public void CreateFile(EntityDeclarationDAL declaration, string _path)
        {
            using (StreamWriter sw = new StreamWriter(_path))
            {
                sw.WriteLine(declaration.TextDeclaration);
            }
        }
    }
}
