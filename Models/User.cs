using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace finalproject_cidm3312.Models
{
    public class User
    {
        public int UserId {get; set;}	// Primary Key

        [BindProperty]
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName {get; set;}
        public List<UserRecipe> UserRecipes {get; set;} // Nav prop - A user can have many recipes         
    }
}

