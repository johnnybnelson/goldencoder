using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Models.Domain.Friends
{
    public class BaseFriend
    {
        [Range(1, int.MaxValue)]  //allowable range
        public int Id { get; set; }

    }
}
