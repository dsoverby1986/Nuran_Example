using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuran_Example.Models
{
    public class ExampleViewModel
    {
        public int? ThingId { get; set; }
        public SelectList SelectList { get; set; }
    }
}
