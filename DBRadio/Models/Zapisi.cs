using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDRadio.Models

{
    public class Zapisi
    {
        public long ID { get; set; }

        [Display(Name = "Код записи")]
        public long Record_ID { get; set; }

        [Display(Name = "Наименование")]
		public string Name { get; set; }

        [Display(Name = "Исполнитель")]
        public DbSet<Ispolniteli> Perfomer_ID { get; set; }

        [Display(Name = "Код исполнителя")]
        public long PerformerID { get; set; }

        [Display(Name = "Альбом")]
        public string Albom { get; set; }

        [Display(Name = "Год")]
        public int Year { get; set; }

        [Display(Name = "Жанр")]
        public DbSet<Zhanri> Genre_ID { get; set; }

        [Display(Name = "Код жанра")]
        public long GenreID { get; set; }

        [Display(Name = "Дата записи")]
        public DateTime RecordDate { get; set; }

        [Display(Name = "Длительность")]
        public int Duration { get; set; }

        [Display(Name = "Рейтинг")]
        public int Rating { get; set; }
    }
}