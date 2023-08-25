using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kclinic.Models
{
    public class About
    {
		public int Id { get; set; }
		public string Title { get; set; }

        public string Content { get; set; }
		[ValidateNever]
		public string ImageUrl { get; set; }
	}
}
