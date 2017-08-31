using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_HW.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public IQueryable<客戶資料> 取得未刪除資料()
        {
            return this.All().Where(x => x.is_del != true);
        }

        public void delete(int id)
        {
            客戶資料 客戶資料 = this.Find(id);
            客戶資料.is_del = true;
            this.UnitOfWork.Commit();
        }

        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}