//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan
    {
        public int Id { get; set; }
        public System.DateTime LoanDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
