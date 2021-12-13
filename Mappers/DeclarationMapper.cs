using Entities;
using EntitiesBLL;
using EntitiesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public static class DeclarationMapper
    {
        public static EntityDeclarationDAL DeclarationBLLtoDAL(this EntityDeclarationBLL declaration)
        {
            var declarationDAL = new EntityDeclarationDAL();
            declarationDAL.Client = declaration.Client.ClientBLLtoDAL();
            declarationDAL.TextDeclaration = declaration.TextDeclaration;
            declarationDAL.ID = declaration.ID;
            return declarationDAL;

        }
        public static EntityDeclarationPL DeclarationBLLtoPL(this EntityDeclarationBLL declaration)
        {
            var declarationPL = new EntityDeclarationPL(declaration.Client.ClientBLLtoPL());
            declarationPL.ID = declaration.ID;
            declarationPL.TextDeclaration =declaration.TextDeclaration;
            return declarationPL;
        }
        public static EntityDeclarationBLL DeclarationDALtoBLL(this EntityDeclarationDAL declaration)
        {
            var declarationBLL = new EntityDeclarationBLL(declaration.Client.ClientDALtoBLL());
            declarationBLL.TextDeclaration = declaration.TextDeclaration;
            declarationBLL.ID = declaration.ID;
            return declarationBLL;
        }
        public static EntityDeclarationBLL DeclarationPLtoBLL(this EntityDeclarationPL declaration)
        {
            var declarationBLL = new EntityDeclarationBLL(declaration.Client.ClientPLtoBLL());
            declarationBLL.TextDeclaration = declaration.TextDeclaration;
            declarationBLL.ID = declaration.ID;
            return declarationBLL;
        }
    }
}
