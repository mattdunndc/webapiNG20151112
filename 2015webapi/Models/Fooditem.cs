namespace _2015webapi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fooditem
    {
        public int ID { get; set; }

        public double? Food_Code { get; set; }

        [StringLength(255)]
        public string Display_Name { get; set; }

        public double? Portion_Default { get; set; }

        [StringLength(255)]
        public string Portion_Amount { get; set; }

        [StringLength(255)]
        public string Portion_Display_Name { get; set; }

        [StringLength(255)]
        public string Factor { get; set; }

        [StringLength(255)]
        public string Increment { get; set; }

        [StringLength(255)]
        public string Multiplier { get; set; }

        [StringLength(255)]
        public string Grains { get; set; }

        [StringLength(255)]
        public string Whole_Grains { get; set; }

        [StringLength(255)]
        public string Vegetables { get; set; }

        [StringLength(255)]
        public string Orange_Vegetables { get; set; }

        [StringLength(255)]
        public string Drkgreen_Vegetables { get; set; }

        [StringLength(255)]
        public string Starchy_vegetables { get; set; }

        [StringLength(255)]
        public string Other_Vegetables { get; set; }

        [StringLength(255)]
        public string Fruits { get; set; }

        [StringLength(255)]
        public string Milk { get; set; }

        [StringLength(255)]
        public string Meats { get; set; }

        [StringLength(255)]
        public string Soy { get; set; }

        [StringLength(255)]
        public string Drybeans_Peas { get; set; }

        [StringLength(255)]
        public string Oils { get; set; }

        [StringLength(255)]
        public string Solid_Fats { get; set; }

        [StringLength(255)]
        public string Added_Sugars { get; set; }

        [StringLength(255)]
        public string Alcohol { get; set; }

        [StringLength(255)]
        public string Calories { get; set; }

        [StringLength(255)]
        public string Saturated_Fats { get; set; }
    }
}
