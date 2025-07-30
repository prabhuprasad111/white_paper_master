using System;
using System.ComponentModel.DataAnnotations;

namespace white_paper_master.Models

{
    public class OdWpPoliceStation
    {
        [Key]
        public int PS_CD { get; set; }
        public int? LANG_CD { get; set; } 
        public int? STATE_CD { get; set; }
        public int? DISTRICT_CD { get; set; }
        public int? SUB_DISTRICT_CD { get; set; }
        public string PS { get; set; }
        
    }
    public class OdWpDistrict
    {
        [Key]
        public int DISTRICT_CD { get; set; }
        public int? LANG_CD { get; set; } 
        public int? STATE_CD { get; set; }
        public int? RANGE_CD { get; set; }
        public string DISTRICT { get; set; }

    }

}

