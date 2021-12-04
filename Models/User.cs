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
        public string FirstName {get; set;}
        public string LastName {get; set;}
        
        public List<Recipe> Recipes {get; set;} // Nav prop - A user can have many recipes         
    }
}

