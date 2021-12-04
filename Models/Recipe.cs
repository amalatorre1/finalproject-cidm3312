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
        public string Title {get; set;}
        public string Type {get; set;}
        public int Servings {get; set;}
        public int Duration {get; set;}
        public string Ingredients {get; set;}
        public string Instructions {get; set;}
        public int Rating {get; set;}
        
        public int UserId {get; set;} // FK
        public User User {get; set;} // Nav prop
    }
}