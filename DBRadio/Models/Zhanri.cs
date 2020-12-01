using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDRadio.Models

{
    public class Zhanri
    {
        public long ID { get; set; }

        [Display(Name = "Код жанра")]
        public long Genre_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Discription { get; set; }
    }
}