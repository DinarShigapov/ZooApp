//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooPlusApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListAnimal
    {
        public int ID { get; set; }
        public int AnimalId { get; set; }
        public int ZooId { get; set; }
        public int Count { get; set; }
    
        public virtual Animal Animal { get; set; }
        public virtual ZooCompany ZooCompany { get; set; }
    }
}
