using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_HW.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public IQueryable<客戶銀行資訊> 取得未刪除資料()
        {
            return this.All().Where(x => x.is_del != true);
        }

        public void delete(int id)
        {
            客戶銀行資訊 客戶銀行資訊 = this.Find(id);
            客戶銀行資訊.is_del = true;
            this.UnitOfWork.Commit();
        }

        public 客戶銀行資訊 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}