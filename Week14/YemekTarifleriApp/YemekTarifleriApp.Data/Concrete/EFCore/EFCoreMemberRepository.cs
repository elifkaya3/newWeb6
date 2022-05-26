using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Data.Abstract;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Data.Concrete.EFCore
{
    public class EFCoreMemberRepository:EFCoreGenericRepository<Member,RecipeAppContext>,IMemberRepository
    {
        //ekstra metod varsa implement edilecek
    }
}
