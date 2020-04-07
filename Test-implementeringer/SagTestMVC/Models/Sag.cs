using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SagTest.Models
{
    public class Sag
    {
        public int SubjectId { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        //public string URLImage { get; set; }

        public List<ImageModel> imageModelsList { get; set; }

        [NotMapped]
        [DisplayName("Upload file")]
        public IFormFile ImageFile { get; set; }

        public string ImageName { get; set; }

    }
}
