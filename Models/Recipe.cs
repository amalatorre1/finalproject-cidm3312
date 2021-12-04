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
    public class Recipe
    {
        public int RecipeId {get; set;}	// PK

        [BindProperty]
        [Display(Name = "Title")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title {get; set;}

        [BindProperty]
        [Display(Name = "Type")]
        [StringLength(10)]
        [Required]
        public string Type {get; set;}

        [BindProperty]
        [Display(Name = "Servings")]
        [Range(1, 100)]
        [Required]
        public int Servings {get; set;}

        [BindProperty]
        [Display(Name = "Duration")]
        [Required]
        public int Duration {get; set;}

        [BindProperty]
        [Display(Name = "Ingredients")]
        [Required]
        public string Ingredients {get; set;}

        [BindProperty] 
        [Display(Name = "Instructions")]
        [Required]
        public string Instructions {get; set;}

        [BindProperty]
        public int Rating {get; set;}

        public List<User> Users {get; set;} // Nav prop - A user can have many recipes 
    }
}