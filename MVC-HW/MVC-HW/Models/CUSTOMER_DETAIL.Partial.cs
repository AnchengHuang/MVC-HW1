namespace MVC_HW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(CUSTOMER_DETAILMetaData))]
    public partial class CUSTOMER_DETAIL
    {
    }
    
    public partial class CUSTOMER_DETAILMetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 聯絡人數量 { get; set; }
        public Nullable<int> 銀行帳戶數量 { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
