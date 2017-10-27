using Lightpoint.Task.DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lightpoint.Task.DAL.Entity_Framework
{
    class DbInitializer: CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            
            #region shops
            var shops = new List<Shop>()
            {
                new Shop()
                {
                    Name = "Glorious Gifts",
                    Adress = "70 Bowman St. South Windsor, CT 06074",
                    Mode = "8:00 - 21:00"
                },
                new Shop()
                {
                    Name = "Heaven Sent Gift Delivery",
                    Adress = "70 Bowman St. South Windsor, CT 06074",
                    Mode = "8:00 - 21:00"
                },
                new Shop()
                {
                    Name = "Avenue 52 Gifts",
                    Adress = "514 S. Magnolia St. Orlando, FL 32806",
                    Mode = "8:00 - 21:00"
                },
                new Shop()
                {
                    Name = "The Wishing Mountain",
                    Adress = "71 Pilgrim Avenue Chevy Chase, MD 20815",
                    Mode = "Around the clock"
                },
                new Shop()
                {
                    Name = "Millionhairs",
                    Adress = "4 Goldfield Rd. Honolulu, HI 96815",
                    Mode = "Around the clock"
                },
                new Shop()
                {
                    Name = "The Growing Stove Boutique",
                    Adress = "123 6th St. Melbourne, FL 32904",
                    Mode = "Around the clock"
                }
            };
            context.Shops.AddRange(shops);
            #endregion


            #region products
            var products = new List<Product>()
            {
                new Product()
                {
                    Name = "TaylorMade Golf M2",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[0]
                },
                new Product()
                {
                    Name = "MICROSOFT Xbox One S 500",
                    Description = "The Xbox One® S is 40% smaller than the Xbox One®, and lighter too." +
                    " The power supply is built in so you no longer have a bulky power unit attached to the" +
                    " back of the console. The look of the console has also been updated from the iconic black" +
                    " exterior to a new sleek, white design with black accents. Bluetooth and infrared are now " +
                    "supported too, but the Kinect port has been removed. As well as a new compact size, the Xbox" +
                    " One® S also includes an HD Blu-ray player, which is not available with the PS4™, PS4™ Pro," +
                    " PS4™ Slim, Wii U™, Xbox One® or Xbox One® Elite.",
                    Shop = shops[0]
                },
                new Product()
                {
                    Name = "хорошо уникальный ожерелье классный из нержавеющей стали серебра плетеный",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[0]
                },
                new Product()
                {
                    Name = "TaylorMade Golf M2",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[0]
                },
                new Product()
                {
                    Name = "MICROSOFT Xbox One S 500",
                    Description = "The Xbox One® S is 40% smaller than the Xbox One®, and lighter too." +
                    " The power supply is built in so you no longer have a bulky power unit attached to" +
                    " the back of the console. The look of the console has also been updated from the" +
                    " iconic black exterior to a new sleek, white design with black accents. Bluetooth and" +
                    " infrared are now supported too, but the Kinect port has been removed. As well as a new" +
                    " compact size, the Xbox One® S also includes an HD Blu-ray player, which is not available" +
                    " with the PS4™, PS4™ Pro, PS4™ Slim, Wii U™, Xbox One® or Xbox One® Elite.",
                    Shop = shops[0]
                },
                new Product()
                {
                    Name = "[Mizon] спокойной ночи белый спальный маска трубка 50 мл",
                    Description = "Niacinamide + mulberry extract / Mulberry root extract /" +
                    " pantethineNiacinamide effectively helps skin whitening blocking melanin travel." +
                    " Makes your skin bright and clean. Mulberry extrac, mulberry root extract, pantethine" +
                    " makes your skin even. Whitening care while sleeping specially take care of your skin " +
                    "deeply.High expectations on whitening effect",
                    Shop = shops[0]
                },
                new Product()
                {
                    Name = "Mizon Fruit Therapy Apple smoothie Peeling Gel 120ml",
                    Description = "[Mild Exfoliation]– Gommage Peeling. Apple and sugar cane maple" +
                    " extracts moisturize and soothe skin after exfoliation. It makes skin surface even and smooth.",
                    Shop = shops[1]
                },
                new Product()
                {
                    Name = "Islero кик боксерские гелевые перчатки ММА боксерской груши спарринг тайский бокс борьба тренировки Uf",
                    Description = "Made up of High Quality Teflon and REX Leather " +
                    "Provides Ultimate Protection and Shock Absorption with Multi Layered High Density Foam Core and GEL Protection" +
                    "Light weight Yet durable design makes it Ideal for Training and Bag Workouts" +
                    "Features Mesh Interior with Ventilation Holes for Improved Air flow and Breath ability" +
                    "D Loop Velcro closure Strap for Tight and non slip Fitting",
                    Shop = shops[1]
                },
                new Product()
                {
                    Name = "TaylorMade Golf M2",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[2]
                },
                new Product()
                {
                    Name = "MICROSOFT Xbox One S 500",
                    Description = "The Xbox One® S is 40% smaller than the Xbox One®, and lighter too." +
                    " The power supply is built in so you no longer have a bulky power unit attached to the" +
                    " back of the console. The look of the console has also been updated from the iconic black" +
                    " exterior to a new sleek, white design with black accents. Bluetooth and infrared are now " +
                    "supported too, but the Kinect port has been removed. As well as a new compact size, the Xbox" +
                    " One® S also includes an HD Blu-ray player, which is not available with the PS4™, PS4™ Pro," +
                    " PS4™ Slim, Wii U™, Xbox One® or Xbox One® Elite.",
                    Shop = shops[2]
                },
                new Product()
                {
                    Name = "хорошо уникальный ожерелье классный из нержавеющей стали серебра плетеный",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[3]
                },
                new Product()
                {
                    Name = "TaylorMade Golf M2",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "MICROSOFT Xbox One S 500",
                    Description = "The Xbox One® S is 40% smaller than the Xbox One®, and lighter too." +
                    " The power supply is built in so you no longer have a bulky power unit attached to" +
                    " the back of the console. The look of the console has also been updated from the" +
                    " iconic black exterior to a new sleek, white design with black accents. Bluetooth and" +
                    " infrared are now supported too, but the Kinect port has been removed. As well as a new" +
                    " compact size, the Xbox One® S also includes an HD Blu-ray player, which is not available" +
                    " with the PS4™, PS4™ Pro, PS4™ Slim, Wii U™, Xbox One® or Xbox One® Elite.",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "[Mizon] спокойной ночи белый спальный маска трубка 50 мл",
                    Description = "Niacinamide + mulberry extract / Mulberry root extract /" +
                    " pantethineNiacinamide effectively helps skin whitening blocking melanin travel." +
                    " Makes your skin bright and clean. Mulberry extrac, mulberry root extract, pantethine" +
                    " makes your skin even. Whitening care while sleeping specially take care of your skin " +
                    "deeply.High expectations on whitening effect",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "Mizon Fruit Therapy Apple smoothie Peeling Gel 120ml",
                    Description = "[Mild Exfoliation]– Gommage Peeling. Apple and sugar cane maple" +
                    " extracts moisturize and soothe skin after exfoliation. It makes skin surface even and smooth.",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "Islero кик боксерские гелевые перчатки ММА боксерской груши спарринг тайский бокс борьба тренировки Uf",
                    Description = "Made up of High Quality Teflon and REX Leather " +
                    "Provides Ultimate Protection and Shock Absorption with Multi Layered High Density Foam Core and GEL Protection" +
                    "Light weight Yet durable design makes it Ideal for Training and Bag Workouts" +
                    "Features Mesh Interior with Ventilation Holes for Improved Air flow and Breath ability" +
                    "D Loop Velcro closure Strap for Tight and non slip Fitting",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "TaylorMade Golf M2",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "MICROSOFT Xbox One S 500",
                    Description = "The Xbox One® S is 40% smaller than the Xbox One®, and lighter too." +
                    " The power supply is built in so you no longer have a bulky power unit attached to the" +
                    " back of the console. The look of the console has also been updated from the iconic black" +
                    " exterior to a new sleek, white design with black accents. Bluetooth and infrared are now " +
                    "supported too, but the Kinect port has been removed. As well as a new compact size, the Xbox" +
                    " One® S also includes an HD Blu-ray player, which is not available with the PS4™, PS4™ Pro," +
                    " PS4™ Slim, Wii U™, Xbox One® or Xbox One® Elite.",Shop = shops[4]
                },
                new Product()
                {
                    Name = "хорошо уникальный ожерелье классный из нержавеющей стали серебра плетеный",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "TaylorMade Golf M2",
                    Description = "Новый: Совершенно новый, неиспользованный, неоткрытый, неповрежденный товар в оригинальной упаковке ",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "MICROSOFT Xbox One S 500",
                    Description = "The Xbox One® S is 40% smaller than the Xbox One®, and lighter too." +
                    " The power supply is built in so you no longer have a bulky power unit attached to" +
                    " the back of the console. The look of the console has also been updated from the" +
                    " iconic black exterior to a new sleek, white design with black accents. Bluetooth and" +
                    " infrared are now supported too, but the Kinect port has been removed. As well as a new" +
                    " compact size, the Xbox One® S also includes an HD Blu-ray player, which is not available" +
                    " with the PS4™, PS4™ Pro, PS4™ Slim, Wii U™, Xbox One® or Xbox One® Elite.",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "[Mizon] спокойной ночи белый спальный маска трубка 50 мл",
                    Description = "Niacinamide + mulberry extract / Mulberry root extract /" +
                    " pantethineNiacinamide effectively helps skin whitening blocking melanin travel." +
                    " Makes your skin bright and clean. Mulberry extrac, mulberry root extract, pantethine" +
                    " makes your skin even. Whitening care while sleeping specially take care of your skin " +
                    "deeply.High expectations on whitening effect",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "Mizon Fruit Therapy Apple smoothie Peeling Gel 120ml",
                    Description = "[Mild Exfoliation]– Gommage Peeling. Apple and sugar cane maple" +
                    " extracts moisturize and soothe skin after exfoliation. It makes skin surface even and smooth.",
                    Shop = shops[4]
                },
                new Product()
                {
                    Name = "Islero кик боксерские гелевые перчатки ММА боксерской груши спарринг тайский бокс борьба тренировки Uf",
                    Description = "Made up of High Quality Teflon and REX Leather " +
                    "Provides Ultimate Protection and Shock Absorption with Multi Layered High Density Foam Core and GEL Protection" +
                    "Light weight Yet durable design makes it Ideal for Training and Bag Workouts" +
                    "Features Mesh Interior with Ventilation Holes for Improved Air flow and Breath ability" +
                    "D Loop Velcro closure Strap for Tight and non slip Fitting",
                    Shop = shops[4]
                }
            };
            context.Products.AddRange(products);
            #endregion
            context.SaveChanges();
        }
    }
}
