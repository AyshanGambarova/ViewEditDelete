using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Models
{
    public class Messages
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad qeyd olunmayıb"), MaxLength(100)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email qeyd olunmayıb"), MaxLength(100)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Rəy qeyd olunmayıb"), MaxLength(100)]
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Messages()
        { }

        public Messages(string Name,string Email,string Message,DateTime Date)
        {
            this.Name = Name;
            this.Email = Email;
            this.Message = Message;
            this.Date = Date;
        }
    }

}
