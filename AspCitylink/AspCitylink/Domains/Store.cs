//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspCitylink.Domains
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store
    {
        public int StoreId { get; set; }
        public int Quantity { get; set; }
    
        public virtual Product StoreProduct { get; set; }
    }
}
