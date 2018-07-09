using codeFirst2.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirst2.DataLayer
{
    public class SiteByYear: ITableEntity
    {
        [Key]
        public int Id { get; set; }
        public int CurrentLayerId { get; set; }
        public int CurrentCropId { get; set; }
        public int CurrentSiteId { get; set; }

        public SiteByYear(int i_ID, int i_CurrentLayerId, int i_CurrentCropId, int i_CurrentSiteId)
        {
            Id = i_ID;
            CurrentCropId = i_CurrentCropId;
            CurrentLayerId = i_CurrentLayerId;
            CurrentSiteId = i_CurrentSiteId;
        }

        public SiteByYear()
        {

        }
    }
}