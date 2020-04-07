using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SagTest.Models
{
    public class ImageModel
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }

        public int SagFKId { get; set; }

        public Sag Sag { get; set; }
       
    }
}
