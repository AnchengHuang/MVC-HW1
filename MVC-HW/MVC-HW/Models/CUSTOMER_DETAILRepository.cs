using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC_HW.Models
{   
	public  class CUSTOMER_DETAILRepository : EFRepository<CUSTOMER_DETAIL>, ICUSTOMER_DETAILRepository
	{

	}

	public  interface ICUSTOMER_DETAILRepository : IRepository<CUSTOMER_DETAIL>
	{

	}
}