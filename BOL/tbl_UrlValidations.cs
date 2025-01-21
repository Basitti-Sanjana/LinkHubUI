using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class UniqueUrlAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            LinkHubDbEntities db = new LinkHubDbEntities();
            string urlValue = value.ToString();
            int count = db.tbl_Url.Where(x => x.Url == urlValue).ToList().Count;
            if (count != 0)
                return new ValidationResult("Url Already Exists.");

            return ValidationResult.Success;
        }
    }
    public class tbl_UrlValidations
    {
        [Required]
        public string UrlTitle { get; set; }

        [Required]
        [Url]
        [UniqueUrl]
        public string Url { get; set; }

        [Required]
        public string UrlDesc { get; set; }

    }
    [MetadataType(typeof(tbl_UrlValidations))]
    public partial class tbl_Url
    {

    }
}