using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Data.Concrete.EFCore
{
    public class EFCoreMemberRepository:EFCoreGenericRepository<Member,RecipeAppContext>
    {
        //ekstra metod varsa implement edilecek
    }
}
