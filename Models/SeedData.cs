namespace CupcakeMVC.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //dessert
                if (!context.Desserts.Any())
                {
                    context.Desserts.AddRange(new List<Dessert>()
                    {
                         new Dessert()
                         {
                            Name="Vanilla Cake",
                            DessertPhotoURL = "https://media.istockphoto.com/photos/white-cream-cupcake-with-color-sprinkles-on-rose-picture-id1325366585?k=20&m=1325366585&s=612x612&w=0&h=riR81chPNQzmVWp4X162-v7k6hfybMLt0iKICME2P8A=",
                            Description="Dessert",
                            Price=9
                         },
                          new Dessert()
                         {
                             Name = "Chocolate Cake",
                             DessertPhotoURL = "https://images.unsplash.com/photo-1610306212789-7508d076e925?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGN1cGNha2UlMjB2YW5pbGxhfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                             Description = "Dessert",
                             Price = 10
                         },
                           new Dessert()
                          {
                              Name = "Lemon Cream",
                              DessertPhotoURL = "https://images.unsplash.com/photo-1576618148400-f54bed99fcfd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8Y3VwY2FrZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                              Description = "Dessert",
                              Price =8
                          },
                           new Dessert()
                           {
                               Name = "Nut Cream",
                               DessertPhotoURL = "https://images.unsplash.com/photo-1603532648955-039310d9ed75?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y3VwY2FrZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                               Description = "Dessert",
                               Price =7
                           },
                           new Dessert()
                           {
                                Name = "Cookies & Dream",
                                DessertPhotoURL = "https://media.istockphoto.com/photos/chocolate-cupcake-with-cream-tasty-cupcakes-with-ganache-muffin-picture-id1289886018?k=20&m=1289886018&s=612x612&w=0&h=GcayEn0f_ljpPdINX3Z7hvEVCUOmIsg35o7mjBPM_I4=",
                                Description = "Dessert",
                                Price =9
                           },
                           new Dessert()
                           {
                                 Name = "Pumpkin Cake",
                                 DessertPhotoURL = "https://media.istockphoto.com/photos/pumpkin-cupcake-picture-id1184194329?k=20&m=1184194329&s=612x612&w=0&h=pHYBB_0fSDe9DDKuCm2jk9hsbhdZU0OlIeB-2KZrKgU=",
                                 Description = "Dessert",
                                 Price =10
                           },
                           new Dessert()
                           {
                                  Name = "Red Velvet",
                                  DessertPhotoURL = "https://images.unsplash.com/photo-1614707267537-b85aaf00c4b7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Y3VwY2FrZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                                  Description = "Dessert",
                                  Price =7
                           },
                           new Dessert()
                           {
                                   Name = "Rainbow Shadow",
                                   DessertPhotoURL = "https://media.istockphoto.com/photos/rainbow-of-cupcakes-picture-id95783805?k=20&m=95783805&s=612x612&w=0&h=o1m_iw2HmvJHN0A2FWdgsIPWAt2OqRemsrIJnoqPL-4=",
                                   Description = "Dessert",
                                   Price =10
                           }
                    });
                    context.SaveChanges();

                }
                //drinks
                if (!context.Drink.Any())
                {
                    context.Drink.AddRange(new List<Drinks>()
                    {
                        new Drinks()
                        {
                            Name="Espresso",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1520031607889-97ba0c7190ff?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8aWNlZCUyMGVzcHJlc3NvfGVufDB8MXwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price= 2
                        },
                        new Drinks()
                        {
                            Name="Mocha",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1589396575653-c09c794ff6a6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8bW9jaGF8ZW58MHwxfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price=3
                        },
                        new Drinks()
                        {
                            Name="Iced Caffe Latte",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1517701604599-bb29b565090c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8aWNlZCUyMGxhdHRlfGVufDB8MXwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price=3
                        },
                        new Drinks()
                        {
                            Name="Iced Americano",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1582572430474-3acf30221916?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8aWNlZCUyMGFtZXJpY2Fub3xlbnwwfDF8MHx8&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price=2
                        },
                        new Drinks()
                        {
                            Name="Bubble Tea",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1558857563-b371033873b8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8YnViYmxlJTIwdGVhfGVufDB8MXwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price=5
                        },
                        new Drinks()
                        {
                            Name="Lemonade",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1621263764928-df1444c5e859?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8bGVtb25hZGV8ZW58MHwxfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price=4
                        },
                        new Drinks()
                        {
                            Name="Coke",
                            DrinkPhotoURL="https://media.istockphoto.com/photos/cuba-libre-picture-id155354048?k=20&m=155354048&s=612x612&w=0&h=rHHQKSyWuAil2EzBo3DsecUSVOmbQxai1Nod84LFOZA=",
                            Description="Drink",
                            Price=1
                        },
                        new Drinks()
                        {
                            Name="Milkshake",
                            DrinkPhotoURL="https://images.unsplash.com/photo-1577805947697-89e18249d767?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8bWlsa3NoYWtlfGVufDB8MXwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            Description="Drink",
                            Price=4
                        }
                    });
                    context.SaveChanges();
                }
                //double menu
                if (!context.DoubleMenus.Any())
                {
                    context.DoubleMenus.AddRange(new List<DoubleMenu>() {

                        new DoubleMenu()
                        {
                            Name = "Promotional Menu 1",
                            ImageUrl = "https://images.unsplash.com/photo-1634113077529-90edd7b82ddf?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y2FrZSUyNmNvZmZlZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            Description = "Chocolate Cake+Espresso",
                            Price = 10,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(20),
                            DoubleMenuCategory=DoubleMenuCategory.Dessert,
                            DrinksId=1,
                            DessertId=2
                        },

                         new DoubleMenu()
                         {
                             Name = "Promotional Menu 2",
                             ImageUrl = "https://images.unsplash.com/photo-1608991466857-3927781aa98e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8ZG9udXQlMjZjb2ZmZWV8ZW58MHwxfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                             Description = "Nut Cream+Americano",
                             Price = 12,
                             StartDate = DateTime.Now,
                             EndDate = DateTime.Now.AddDays(20),
                             DoubleMenuCategory=DoubleMenuCategory.Dessert,
                             DrinksId=4,
                             DessertId=4

                         }
                     });
                    context.SaveChanges();
                }

            }
        }
    }
}
