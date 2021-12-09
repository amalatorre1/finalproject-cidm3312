using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace finalproject_cidm3312.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<RecipeDbContext>>()))
            {
                // Look for any recipes
                if (context.Recipes.Any())
                {
                    return; // DB has been seeded
                }

                context.Users.AddRange(
                    new User { 
                        FirstName = "Anthony", 
                        LastName = "Bourdain",
                        Recipes = new List<Recipe> {
                            new Recipe {
                                Title="Tomatillo Salsa Verde", 
                                Type="Appetizer", 
                                Servings=8, 
                                Duration=30, 
                                Ingredients="1 pound tomatillos, 1/2 cup finely chopped onion, 1 teaspoon minced garlic, 1 serrano chile peppers, 2 tablespoons chopped cilantro, 1 tablespoon chopped fresh oregano, 1/2 teaspoon ground cumin, 1 teaspoons salt, 2 cups water", 
                                Instructions="Place tomatillos, onion, garlic, and chile pepper into a saucepan. Season with cilantro, oregano, cumin, and salt; pour in water. Bring to a boil over high heat, then reduce heat to medium-low, and simmer until the tomatillos are soft, 10 to 15 minutes. Using a blender, carefully puree the tomatillos and water in batches until smooth.", 
                                Rating=4
                                },
                            new Recipe {
                                Title="BLT Sandwich", 
                                Type="Main", 
                                Servings=1, 
                                Duration=15, 
                                Ingredients="4 slices bacon 2 leaves lettuce 2 slices tomato 2 slices bread, toasted 1 tablespoon mayonnaise", 
                                Instructions="Cook the bacon in a large, deep skillet over medium-high heat until evenly browned, about 10 minutes. Drain the bacon slices on a paper towel-lined plate. Arrange the cooked bacon, lettuce, and tomato slices on one slice of bread. Spread one side of remaining bread slice with the mayonnaise. Bring the two pieces together to make a sandwich.", 
                                Rating=2},
                            new Recipe {
                                Title="Chesapeake Bay Pork Chops", 
                                Type="Main", 
                                Servings=8, 
                                Duration=240, 
                                Ingredients="1/2 cup vegetable oil, 1/2 cup apple cider vinegar, 1 tablespoon seafood seasoning (such as Old Bay), 2 cloves minced garlic, 1 tablespoon chopped fresh basil, 1 lime juiced, cracked black pepper to taste, 8 boneless pork chops 1 inch thick", 
                                Instructions="Whisk together the vegetable oil, apple cider vinegar, seafood seasoning, minced garlic, basil, lime juice, and black pepper in a bowl, and pour into a resealable plastic bag. Add the pork chops, coat with the marinade, squeeze out excess air, and seal the bag. Marinate in the refrigerator for 4 to 6 hours, flipping periodically. Preheat an outdoor grill for medium-high heat, and lightly oil the grate. Remove the pork chops from the bags. Discard excess marinade. Grill until the pork is no longer pink in the center, 5 to 7 minutes per side. An instant-read thermometer inserted into the center should read 145 degrees F (63 degrees C).", 
                                Rating=4
                                },
                            new Recipe {
                                Title="Vanilla Ice Cream V", 
                                Type="Dessert", 
                                Servings=32, 
                                Duration=55, 
                                Ingredients="2 quarts half-and-half cream,1/2 pint heavy cream, 1 1/2 cups white sugar, 4 teaspoons vanilla extract, 1 pinch salt", 
                                Instructions="Combine half-and-half, cream, sugar, vanilla and salt in freezer container of ice cream maker. Freeze according to manufacturer's instructions.", 
                                Rating=4
                                },
                            new Recipe {
                                Title="Holiday Eggnog Pie", 
                                Type="Dessert", 
                                Servings=8, 
                                Duration=110, 
                                Ingredients="1 1/4 cups white sugar, 1/4 cup all-purpose flour, 2 cups eggnog, 3 eggs beaten, 1 teaspoon vanilla extract, 1/4 cup unsalted butter melted and cooled slightly, 1 (9 inch) prepared unbaked pie crust thawed", 
                                Instructions="Preheat oven to 350 degrees F (175 degrees C). Mix the sugar and flour together in a mixing bowl. Beat in the eggnog, eggs, and vanilla to make a smooth mixture. Stir in the butter. Pour into the prepared pie crust. Bake in preheated oven until the custard is set, 35 to 40 minutes. Cool before serving.", 
                                Rating=3
                                }                    
                        }
                    },
                    new User {
                        FirstName = "Gordon", 
                        LastName = "Ramsey",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="Best Green Bean Casserole", Type="Side", Servings=6, Duration=25, Ingredients="2 (14.5 ounce) cans green beans, 1 (10.75 ounce) can condensed cream of mushroom soup, 1 (6 ounce) can French fried onions, 1 cup shredded Cheddar cheese", Instructions="Place green beans and soup in a large microwave-safe bowl. Mix well and heat in the microwave on HIGH until warm (3 to 5 minutes). Stir in 1/2 cup of cheese and heat mixture for another 2 to 3 minutes. Transfer green bean mixture to a casserole dish and sprinkle with French fried onions and remaining cheese.  Bake in a preheated 350 degrees F (175 degrees C) oven until the cheese melts and the onions just begin to brown.", Rating=3},
                            new Recipe {Title="Baked Sweet Potatoes", Type="Side", Servings=4, Duration=75, Ingredients="2 tablespoons olive oil, 3 large sweet potatoes, 2 pinches dried oregano, 2 pinches salt, 2 pinches ground black pepper", Instructions="Preheat oven to 350 degrees F (175 degrees C). Coat the bottom of a glass or non-stick baking dish with olive oil, just enough to coat. Wash and peel the sweet potatoes. Cut them into medium size pieces. Place the cut sweet potatoes in the baking dish and turn them so that they are coated with the olive oil. Sprinkle moderately with oregano, and salt and pepper (to taste). Bake in a preheated 350 degrees F (175 degrees C) oven for 60 minutes or until soft.", Rating=4},
                            new Recipe {Title="Easy Roasted Broccoli", Type="Side", Servings=4, Duration=30, Ingredients="14 ounces broccoli, 1 tablespoon olive oil, salt and ground black pepper to taste", Instructions="Preheat oven to 400 degrees F (200 degrees C). Cut broccoli florets from the stalk. Peel the stalk and slice into 1/4-inch slices. Mix florets and stem pieces with olive oil in a bowl and transfer to a baking sheet; season with salt and pepper. Roast in the preheated oven until broccoli is tender and lightly browned, about 18 minutes.", Rating=5},
                            new Recipe {Title="Mom's Scalloped Potatoes", Type="Side", Servings=6, Duration=75, Ingredients="3 pounds potatoes thinly sliced, 1/2 onion thinly sliced, 9 tablespoons all-purpose flour divided, 6 tablespoons butter diced and divided, salt and ground black pepper to taste, 3 cups whole milk or as needed", Instructions="Preheat oven to 375 degrees F (190 degrees C). Grease a 9x13-inch baking dish. Spread about 1/3 of the potato slices into the bottom of the prepared baking dish. Top with about 1/3 of the onion slices. Sprinkle 3 tablespoons flour over the potato and onion. Arrange 2 tablespoons butter atop the flour. Season the entire layer with salt and pepper. Repeat layering twice more. Heat milk in a saucepan until warm. Pour enough warm milk over the mixture in the baking dish so the top of the liquid is level with the final layer of potatoes. Bake in preheated oven until potatoes are tender, 45 to 60 minutes.", Rating=4},
                            new Recipe {Title="Cream Corn Like No Other", Type="Side", Servings=8, Duration=15, Ingredients="2 (10 ounce) packages frozen corn kernels thawed, 1 cup heavy cream, 1 teaspoon salt, 2 tablespoons granulated sugar, 1/4 teaspoon freshly ground black pepper, 2 tablespoons butter, 1 cup whole milk, 2 tablespoons all-purpose flour, 1/4 cup freshly grated Parmesan cheese", Instructions="In a skillet over medium heat, combine the corn, cream, salt, sugar, pepper and butter. Whisk together the milk and flour, and stir into the corn mixture. Cook stirring over medium heat until the mixture is thickened, and corn is cooked through. Remove from heat, and stir in the Parmesan cheese until melted. Serve hot.", Rating=2}
                        }
                    },
                    new User {
                        FirstName = "Roy",
                        LastName = "Choi",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="Easy Meatloaf", Type="Main", Servings=8, Duration=70, Ingredients="1 1/2 pounds ground beef, 1 egg, 1 onion chopped, 1 cup milk, 1 cup dried bread crumbs, salt and pepper to taste, 2 tablespoons brown sugar, 2 tablespoons prepared mustard, 1/3 cup ketchup", Instructions="Preheat oven to 350 degrees F (175 degrees C). In a large bowl, combine the beef, egg, onion, milk and bread OR cracker crumbs. Season with salt and pepper to taste and place in a lightly greased 9x5-inch loaf pan, or form into a loaf and place in a lightly greased 9x13-inch baking dish. In a separate small bowl, combine the brown sugar, mustard and ketchup. Mix well and pour over the meatloaf. Bake at 350 degrees F (175 degrees C) for 1 hour.", Rating=5},
                            new Recipe {Title="Italian Baked Meatballs", Type="Main", Servings=6, Duration=50, Ingredients="1 cup Italian-seasoned bread crumbs, 1/4 cup grated Romano cheese, 2 tablespoons chopped fresh parsley, 1/2 teaspoon salt, 1/2 teaspoon ground black pepper, 1/2 teaspoon garlic powder, 1/2 teaspoon onion powde, 1/2 cup water, 2 eggs, 1 pounds ground beef", Instructions="Preheat the oven to 350 degrees F (175 degrees C). Mix bread crumbs, Romano cheese, parsley, salt, pepper, garlic powder, and onion powder together. Combine with water and eggs. Add ground beef and mix well. Roll mixture into balls and place on a nonstick baking sheet. Bake in the preheated oven until browned, about 30 minutes.", Rating=3},
                            new Recipe {Title="Lemon Rosemary Salmon", Type="Main", Servings=2, Duration=30, Ingredients="1 lemon, thinly sliced 4 sprigs fresh rosemary 2 salmon fillets, bones and skin removed coarse salt to taste 1 tablespoon olive oil, or as needed", Instructions="Preheat oven to 400 degrees F (200 degrees C). Arrange half the lemon slices in a single layer in a baking dish. Layer with 2 sprigs rosemary, and top with salmon fillets. Sprinkle salmon with salt, layer with remaining rosemary sprigs, and top with remaining lemon slices. Drizzle with olive oil. Bake 20 minutes in the preheated oven, or until fish is easily flaked with a fork.", Rating=4}
                        }
                    },
                    new User {
                        FirstName = "Ludo",
                        LastName = "Lefebvre",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="Caramelized Chicken Wings", Type="Appetizer", Servings=6, Duration=65, Ingredients="1 cup water, 1/2 cup white sugar, 1/3 cup soy sauce, 2 tablespoons peanut butter, 1 tablespoon honey, 2 teaspoons wine vinegar, 1 tablespoon minced garlic, 12 large chicken wings tips removed and wings cut in half at joint, 1 teaspoon sesame seeds, or to taste (Optional)", Instructions="In an electric skillet or a large skillet over medium heat, mix together the water, sugar, soy sauce, peanut butter, honey, wine vinegar, and garlic until smooth and the sugar has dissolved. Place the wings into the sauce, cover, and simmer for 30 minutes. Uncover and simmer until the wings are tender and the sauce has thickened, about 30 more minutes, spooning sauce over wings occasionally. Sprinkle with sesame seeds.", Rating=5},
                            new Recipe {Title="Calypso Coffee", Type="Drink", Servings=1, Duration=2, Ingredients="1 fluid ounce rum, 1 fluid ounce creme de cacao liqueur, 8 fluid ounces hot brewed coffee", Instructions="Pour rum and liquor into a mug. Fill mug to the top with coffee.", Rating=4},
                            new Recipe {Title="Spaghetti with Ground Beef", Type="Main", Servings=8, Duration=70, Ingredients="1 pound ground beef, 1 onion chopped, 4 cloves garlic minced, 1 small green bell pepper diced, 1 (28 ounce) can diced tomatoes, 1 (16 ounce) can tomato sauce, 1 (6 ounce) can tomato paste, 2 teaspoons dried oregano, 2 teaspoons dried basil, 1 teaspoon salt, 1/2 teaspoon black pepper", Instructions="Combine ground beef, onion, garlic, and green pepper in a large saucepan. Cook and stir until meat is brown and vegetables are tender. Drain grease. Stir diced tomatoes, tomato sauce, and tomato paste into the pan. Season with oregano, basil, salt, and pepper. Simmer spaghetti sauce for 1 hour, stirring occasionally. Cook noodles according to the package. Add 1/3 cup pasta water to sauce. Mix well and spoon sauce over cooked noodles.", Rating=4},
                            new Recipe {Title="Greens with Cannellini Beans and Pancetta", Type="Side", Servings=2, Duration=40, Ingredients="2 slices pancetta or bacon chopped, 1 tablespoons olive oil, 1 small red onion chopped, 3 cloves garlic crushed, 1 bunch kale roughly chopped, 1 bunch beet greens roughly chopped, salt to taste, 1 (15 ounce) can cannellini beans drained", Instructions="Microwave the chopped pancetta or bacon on high for 3 minutes. Drain the drippings, and set the crispy pancetta aside. In a large frying pan, heat the olive oil over medium heat. Cook onion in oil until soft. Add the crushed garlic cloves, and cook a minute more. Stir in chopped greens, and season with salt to taste (be conservative at this point - you can always add more!). Partially cover the pan, and cook until the greens begin to wilt. Stir in crispy pancetta and cannellini beans. Cook partially covered for 5 more minutes, until the flavors have combined and the greens are tender.", Rating=1}
                        }
                    },
                    new User {
                        FirstName = "Aaron",
                        LastName = "Sanchez",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="Hummus", Type="Appetizer", Servings=16, Duration=20, Ingredients="2 cups canned garbanzo beans drained, 1/3 cup tahini, 1/4 cup lemon juice, 1 teaspoon salt, 2 cloves garlic halved, 1 tablespoon olive oil, 1 pinch paprika, 1 teaspoon minced fresh parsley", Instructions="Place the garbanzo beans, tahini, lemon juice, salt and garlic in a blender or food processor. Blend until smooth. Transfer mixture to a serving bowl. Drizzle olive oil over the garbanzo bean mixture. Sprinkle with paprika and parsley.", Rating=5}
                        }
                    },
                    new User {
                        FirstName = "Albert",
                        LastName = "Adria",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="Guacamole", Type="Appetizer", Servings=4, Duration=10, Ingredients="3 avocados - peeled, pitted, and mashed, 1 lime, juiced, 1 teaspoon salt, 1/2 cup diced onion, 3 tablespoons chopped fresh cilantro, 2 roma (plum) tomatoes - diced, 1 teaspoon minced garlic", Instructions="In a medium bowl, mash together the avocados, lime juice, and salt. Mix in onion, cilantro, tomatoes, and garlic. Stir in cayenne pepper. Refrigerate 1 hour for best flavor, or serve immediately.", Rating=4},
                            new Recipe {Title="Honey-Garlic Slow Cooker Chicken Thighs", Type="Main", Servings=4, Duration=360, Ingredients="4 skinless oneless chicken thighs, 1/2 cup soy sauce, 1/2 cup ketchup, 1/3 cup honey, 3 cloves minced garlic, 1 teaspoon dried basil", Instructions="Lay chicken thighs into the bottom of a 4-quart slow cooker. Whisk soy sauce, ketchup, honey, garlic, and basil together in a bowl; pour over the chicken. Cook on Low for 6 hours.", Rating=4},
                            new Recipe {Title="Simple Moscow Mule", Type="Drink", Servings=1, Duration=10, Ingredients="ice, 1/2 fresh lime, 2 fluid ounces vodka, 4 fluid ounces ginger beer or to taste, 2 lime slices", Instructions="Fill a tall glass with ice. Squeeze 1/2 lime over ice. Pour vodka over ice and top with ginger beer. Garnish with lime slices.", Rating=5}
                        }
                    },
                    new User {
                        FirstName = "Jose",
                        LastName = "Andres",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="Best Big, Fat, Chewy Chocolate Chip Cookie", Type="Dessert", Servings=18, Duration=40, Ingredients="2 cups all-purpose flour, 1/2 teaspoon baking soda, 1/2 teaspoon salt, 3/4 cup unsalted butter melted, 1 cup packed brown sugar, 1/2 cup white sugar, 1 tablespoon vanilla extract, 1 egg, 1 egg yolk, 2 cups semisweet chocolate chips", Instructions="Preheat the oven to 325 degrees F (165 degrees C). Grease cookie sheets or line with parchment paper. Sift together the flour, baking soda and salt; set aside. In a medium bowl, cream together the melted butter, brown sugar and white sugar until well blended. Beat in the vanilla, egg, and egg yolk until light and creamy. Mix in the sifted ingredients until just blended. Stir in the chocolate chips by hand using a wooden spoon. Drop cookie dough 1/4 cup at a time onto the prepared cookie sheets. Cookies should be about 3 inches apart. Bake for 15 to 17 minutes in the preheated oven, or until the edges are lightly toasted. Cool on baking sheets for a few minutes before transferring to wire racks to cool completely.", Rating=5},
                            new Recipe {Title="Tiramisu Cheesecake", Type="Dessert", Servings=12, Duration=300, Ingredients="1 (12 ounce) package ladyfingers, 1/4 cup butter melted, 1/4 cup coffee-flavored liqueur divided, 3 (8 ounce) packages cream cheese, 1 (8 ounce) container mascarpone cheese, 1 cup white sugar, 2 eggs, 1/4 cup all-purpose flour, 1 (1 ounce) square semisweet chocolate", Instructions="Preheat oven to 350 degrees F (175 degrees C). Place a pan of water on the bottom of the oven. Crush the package of ladyfingers to fine crumbs. Mix the melted butter into the crumbs. Moisten with 2 tablespoons of the coffee liqueur. Press into an 8-inch springform pan. In a large bowl, mix cream cheese, mascarpone, and sugar until very smooth. Add 2 tablespoons coffee liqueur, and mix. Add the eggs and the flour; mix slowly just until smooth. Pour batter over crust in the springform pan. Place pan on middle rack of oven. Bake until just set, 40 to 45 minutes. Open oven door, and turn off the heat. Leave cake to cool in oven for 20 minutes. Remove from oven, and let it finish cooling, about 30 minutes. Refrigerate for at least 3 hours, or overnight. Grate semisweet chocolate over the top right before serving.", Rating=4}
                        }
                    },
                    new User {
                        FirstName = "Tyson",
                        LastName = "Cole",
                        Recipes = new List<Recipe> {
                            new Recipe {Title="French Onion-Breaded Baked Chicken", Type="Main", Servings=4, Duration=35, Ingredients="1 cup bread crumbs, 1 (1 ounce) package dry French onion soup mix, 1/3 cup mayonnaise, 1 tablespoon garlic paste (Optional), 4 skinless boneless chicken breasts", Instructions="Preheat the oven to 425 degrees F (220 degrees C). Mix bread crumbs and dry soup mix together in a bowl. Mix mayonnaise and garlic paste together in a separate bowl. Microwave on high to thin out consistency, 20 to 30 seconds. Brush chicken breasts with the mayonnaise mixture. Cover with the crumb mixture. Place on a baking sheet. Bake on the middle rack of the preheated oven until chicken is no longer pink in the center and juices run clear, about 20 minutes. An instant-read thermometer inserted into the center should read at least 165 degrees F (74 degrees C).", Rating=4},
                            new Recipe {Title="Homemade Blackberry Lemonade", Type="Drink", Servings=4, Duration=7, Ingredients="3/4 cup white sugar, 4 1/2 cups water divided, 1 cup blackberries, 2 tablespoons white sugar, 1 cup freshly squeezed lemon juice, ice cubes", Instructions="Heat 3/4 cup sugar and 1/2 cup water in a small saucepan over medium heat. Cook and stir until sugar has dissolved, about 2 minutes. Let cool. Place blackberries and remaining 2 tablespoons of sugar in a blender. Blend until smooth. Combine simple syrup, blended blackberries, remaining 4 cups of water, and lemon juice. Place a fine-mesh sieve over a pitcher and pour lemonade into the pitcher. Discard solids. Serve over ice.", Rating=2}
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}