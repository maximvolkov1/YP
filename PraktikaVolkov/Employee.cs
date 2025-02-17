//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaVolkov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Acceptence = new HashSet<Acceptence>();
            this.Dismissal = new HashSet<Dismissal>();
            this.Moving = new HashSet<Moving>();
        }
    
        public int IdEmployee { get; set; }
        public string FIO { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
        public int IdPost { get; set; }
        public int IdDepartment { get; set; }
        public int IdStaffingTable { get; set; }
        public System.DateTime DateAcceptence { get; set; }
        public Nullable<System.DateTime> DateDismissal { get; set; }
        public Nullable<System.DateTime> DateMoving { get; set; }
        public decimal Salary { get; set; }
        public int DaysWorked { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acceptence> Acceptence { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dismissal> Dismissal { get; set; }
        public virtual Post Post { get; set; }
        public virtual StaffingTable StaffingTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moving> Moving { get; set; }
    }
}
