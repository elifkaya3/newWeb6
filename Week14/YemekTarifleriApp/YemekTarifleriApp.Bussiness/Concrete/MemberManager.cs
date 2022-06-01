using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Bussiness.Abstract;
using YemekTarifleriApp.Data.Abstract;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Bussiness.Concrete
{
    public class MemberManager : IMemberService
    {
        IMemberRepository _memberRepository;
        public MemberManager(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
       
        public void Create(Member entity)
        {
            _memberRepository.Create(entity);
        }

        public void Delete(Member entity)
        {
            _memberRepository.Delete(entity);
        }

        public List<Member> GetAll()
        {
            return _memberRepository.GetAll();
        }

        public Member GetById(int id)
        {
            return _memberRepository.GetById(id);
        }

        public void Update(Member entity)
        {
            _memberRepository.Update(entity);
        }

      
    }
}
