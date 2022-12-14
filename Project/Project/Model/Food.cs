//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            this.UserHistory = new HashSet<UserHistory>();
            this.UserFood = new HashSet<UserFood>();
        }
    
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string Type { get; set; }
        public Nullable<int> Kcal { get; set; }
        public string Recipe { get; set; }
        public string Ingredients { get; set; }
        public string Descript { get; set; }
        public Nullable<int> MealTime { get; set; }
        public string Imgsrc { get; set; }
        public string DonVi { get; set; }
        public Nullable<int> Fat { get; set; }
        public Nullable<int> Carbs { get; set; }
        public Nullable<int> Protein { get; set; }
        public Nullable<int> Sat_Fat { get; set; }
        public Nullable<int> Other_Fat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserHistory> UserHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFood> UserFood { get; set; }
    }
}
