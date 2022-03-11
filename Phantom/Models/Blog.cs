using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad qeyd olunmayıb"),MaxLength(100)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Başlıq qeyd olunmayıb"), MaxLength(100)]
        public string Title { get; set; }


        [Required(ErrorMessage = "Şəkil daxil edilməyib"), MaxLength(1000)]
        public string Img { get; set; }


        [Required(ErrorMessage = "Mətn qeyd olunmayib")]
        public string Text { get; set; }

        public Blog()
        { }
        public Blog(string Name,string Title,string Img,string Text)
        {
            this.Name = Name;
            this.Title = Title;
            this.Img = Img;
            this.Text = Text;
        }

        

    }
}
