//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wholesale_Base.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provider
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public System.DateTime DeliveryTime { get; set; }
        public int NumberOfGoods { get; set; }
        public long AccountNumber { get; set; }
        public int ProductID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}