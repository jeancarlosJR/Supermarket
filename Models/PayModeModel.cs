﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Supermarket.Models
{
    internal class PayModeModel
    {
        [DisplayName ("Pay Mode id")]
        public int Id { get; set; }

        [DisplayName ("Pay Mode Name")]
        [Required(ErrorMessage= "Pay mode name is required")]
        [StringLength(50, MinimumLength =3,
            ErrorMessage="´Pay Mode observation is required")]
        public string Name { get; set; }

        [DisplayName(" Observation")]
        [Required(ErrorMessage =" Pay mode observation is required")]
        [StringLength(200,MinimumLength =3,ErrorMessage =" Pay mode observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
