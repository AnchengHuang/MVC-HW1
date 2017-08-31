using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_HW.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public IQueryable<客戶聯絡人> 取得未刪除資料()
        {
            return this.All().Where(x => x.is_del != true);
        }

        public void delete(int id)
        {
            客戶聯絡人 客戶聯絡人 = this.Find(id);
            客戶聯絡人.is_del = true;
            this.UnitOfWork.Commit();
        }

        public 客戶聯絡人 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}