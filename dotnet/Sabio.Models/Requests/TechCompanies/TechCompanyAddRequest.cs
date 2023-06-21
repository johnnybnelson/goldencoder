using Sabio.Models.Domain.Contacts;
using Sabio.Models.Domain.Friends;
using Sabio.Models.Domain.Images;
using Sabio.Models.Domain.Tags;
using Sabio.Models.Domain.Urls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Models.Requests.TechCompanies
{
    public class TechCompanyAddRequest
    {

        [StringLength(100)]  //allowable range
        public string Name { get; set; }

        [StringLength(700)]  //allowable range
        public string Profile { get; set; }

        [StringLength(256)]  //allowable range
        public string Summary { get; set; }

        [StringLength(100)]  //allowable range
        public string Headline { get; set; }


        public string ContactInformation { get; set; }

        [StringLength(50)]  //allowable range
        public string Slug { get; set; }

        [StringLength(10)]  //allowable range
        public string StatusId { get; set; }

        public List<BaseImage> Images { get; set; }

        public List<BaseUrl> Urls { get; set; }

        public int UserId { get; set; }

    }
}
