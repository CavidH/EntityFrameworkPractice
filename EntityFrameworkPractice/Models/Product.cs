//   @author   Cavid Haciyev

using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkPractice.Models
{
    public class Product
    {
        /**
         * Productİd de yaza bilerik
         * ferqli bir adin primariy key olmasi üçün
         * üst sətridə [Key] yazmalıyıq
         */
        //[Key]
        public int Id { get; set; }
        /**
        |   | Name propertisinin max alacaqi deyer uzunlugunu teyin edirik
        v   v
         **/
        [MaxLength(50)]
        [Required]// yəniki NOT NULL 
        public string Name { get; set; }
        public decimal Price  { get; set; } 
        
        
    }
}