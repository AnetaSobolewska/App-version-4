using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ADDED BY DAN

using SQLite;

namespace TourismV3.Models
{
    [Table("RestTable")]
 public class RestTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string RestName { get; set; }
        public string RestAddress { get; set; }
        public int RestPhone { get; set; }
        public string RestFood { get; set; }
        public string RestDescription { get; set; }
        public string RestPicture1 { get; set; }
        public string RestPicture2 { get; set; }
    }
}