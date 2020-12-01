using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDRadio.Models

{
    public class GrafikRaboti
    {
        public long ID { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Сотрудник")]
        public DbSet<Sotrudniki> Staff_ID { get; set; }

        [Display(Name = "Код сотрудника")]
        public long StaffID { get; set; }

        [Display(Name = "Время 1")]
        public DateTime Time1 { get; set; }

        [Display(Name = "Запись 1")]
        public DbSet<Zapisi> Record_ID1 { get; set; }
        [Display(Name = "Код записи 1")]
        public long RecordID1 { get; set; }

        [Display(Name = "Время 2")]
        public DateTime Time2 { get; set; }

        [Display(Name = "Запись 2")]
        public DbSet<Zapisi> Record_ID2 { get; set; }
        [Display(Name = "Код записи 2")]
        public long RecordID2 { get; set; }

        [Display(Name = "Время 3")]
        public DateTime Time3 { get; set; }

        [Display(Name = "Запись 3")]
        public DbSet<Zapisi> Record_ID3 { get; set; }
        [Display(Name = "Код записи 3")]
        public long RecordID3 { get; set; }


    }
}