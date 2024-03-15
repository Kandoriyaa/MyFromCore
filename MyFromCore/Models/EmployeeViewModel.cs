using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MyFromCore.Models
{
    public class EmployeeViewModel  
    {
        [Required(ErrorMessage = "Please Enter valid Name")]
        [MinLength(2,ErrorMessage ="Invalid Name Must Be")]
        [MaxLength(50,ErrorMessage = "Invalid Name Must Be")]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
       
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter valid Name")]
        [MinLength(2, ErrorMessage = "Invalid Name Must Be")]
        [MaxLength(60, ErrorMessage = "Invalid Name Must Be")]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please Select Title")]
        public string Title { get; set; }

        [EmailAddress(ErrorMessage ="Enter Valid Email")]
        public string Email { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                           ErrorMessage = "Entered phone format is not valid.")]
        public string MobileNo { get; set; }

        //Validation
        [Required(ErrorMessage = "Please Enter Gender ")]
        public string Gender { get; set; }

       
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
         public string Password {  get; set; }

        [Required(ErrorMessage = "Please Enter ConformPassword")]
        [Compare("Password", ErrorMessage ="Password and ConformPassword Not Same")]
        public string ConformePassword { get; set; }

        public bool AcceptsTerms {  get; set; }

        public List<SelectListItem>Data { get; set; }


    }
}
