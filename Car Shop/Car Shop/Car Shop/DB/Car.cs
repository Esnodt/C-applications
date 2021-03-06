//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Shop.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int ID { get; set; }
        public byte[] CarImg { get; set; }
        public string CarName { get; set; }
        public string Model { get; set; }
        public string Class { get; set; }
        public string CarBody { get; set; }
        public System.DateTime YearOfProd { get; set; }
        public decimal Price { get; set; }
        public int CountryID { get; set; }
        public Nullable<int> SpecID { get; set; }
    
        public virtual CountryManufacture CountryManufacture { get; set; }
        public virtual Specifications Specifications { get; set; }
    }
}
