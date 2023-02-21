using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_manager_maui.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("programaremodel")]
    public class ProgramareModel
    {
        [PrimaryKey, AutoIncrement, System.ComponentModel.DataAnnotations.Schema.Column("Id")]
        public int Id { get; set; }
        public DateTime ZiuaProgramarii { get; set; }
        public string OraProgramarii { get; set; }
        public string NumeClient { get; set; }
        public string Numar_telefon { get; set; }



    }
}
