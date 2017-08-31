using MVC_HW.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HW.Controllers
{
    public class BaseController:Controller
    {
        protected 客戶資料Repository 客戶資料repo = RepositoryHelper.Get客戶資料Repository();
        protected 客戶聯絡人Repository 客戶聯絡人repo = RepositoryHelper.Get客戶聯絡人Repository();
        protected 客戶銀行資訊Repository 客戶銀行資訊repo = RepositoryHelper.Get客戶銀行資訊Repository();
        protected CUSTOMER_DETAILRepository CUSTOMER_DETAIL_repo = RepositoryHelper.GetCUSTOMER_DETAILRepository();
        protected static int pageSize = Int32.TryParse(ConfigurationManager.AppSettings["PageSize"], out pageSize) == true ? pageSize : 5;

        public BaseController()
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                客戶資料repo.UnitOfWork.Context.Dispose();
                客戶聯絡人repo.UnitOfWork.Context.Dispose();
                客戶銀行資訊repo.UnitOfWork.Context.Dispose();
                CUSTOMER_DETAIL_repo.UnitOfWork.Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}