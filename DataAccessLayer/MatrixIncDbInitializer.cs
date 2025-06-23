using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public static class MatrixIncDbInitializer
    {
        public static void Initialize(MatrixIncDbContext context)
        {
            // Look for any customers.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            // TODO: Hier moet ik nog wat namen verzinnen die betrekking hebben op de matrix.
            // - Denk aan de m3 boutjes, moertjes en ringetjes.
            // - Denk aan namen van schepen
            // - Denk aan namen van vliegtuigen            
            var customers = new Customer[]
            {
                new Customer { Name = "Neo", Address = "123 Elm St" , Active=true},
                new Customer { Name = "Morpheus", Address = "456 Oak St", Active = true },
                new Customer { Name = "Trinity", Address = "789 Pine St", Active = true }
            };
            context.Customers.AddRange(customers);
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category { Name = "Voertuigsystemen" },
                new Category { Name = "Medische Apparatuur" },
                new Category { Name = "Beveiligingssystemen" },
                new Category { Name = "Besturings- & Navigatiesystemen" },
                new Category { Name = "Onderhouds- & Reparatierobots" }
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            var parts = new Part[]
            {
                new Part { Name = "Tandwiel", Description = "Overdracht van rotatie" },
                new Part { Name = "M5 Boutje", Description = "Bevestiging van panelen" },
                new Part { Name = "Hydraulische cilinder", Description = "Openen/sluiten van onderdelen" },
                new Part { Name = "Koelvloeistofpomp", Description = "Koeling van systemen" },
                new Part { Name = "Sensor Module", Description = "Detecteert beweging" },
                new Part { Name = "Laser Diode", Description = "Laser output" },
                new Part { Name = "Servo Motor", Description = "Precisie beweging" },
                new Part { Name = "PCB Board", Description = "Elektronisch circuit" },
                new Part { Name = "Temperatuursensor", Description = "Meet temperatuur" },
                new Part { Name = "Power Supply Unit", Description = "Levert stroom" },
                new Part { Name = "Actuator", Description = "Mechanische beweging" },
                new Part { Name = "Ventilator", Description = "Koelt onderdelen" },
                new Part { Name = "Optische Sensor", Description = "Detecteert licht" },
                new Part { Name = "Kabelboom", Description = "Elektrische verbindingen" },
                new Part { Name = "Behuizing", Description = "Bescherming componenten" },
                new Part { Name = "LCD Display", Description = "Visuele output" },
                new Part { Name = "Magnetische schakelaar", Description = "Detecteert nabijheid" },
                new Part { Name = "Roterende encoder", Description = "Positiebepaling" },
                new Part { Name = "Pneumatische klep", Description = "Luchtstroom regelen" },
                new Part { Name = "Backup batterij", Description = "Noodstroomvoorziening" }
            };
            context.Parts.AddRange(parts);
            context.SaveChanges();

            var products = new Product[]
            {
                new Product { Name = "Nebuchadnezzar", ArticleNumber = "10293847", Manufacturer = "ZionTech", Description = "Het schip waarop Neo voor het eerst de echte wereld leert kennen", Stock = 5, Price = 10000.00m, Category = categories[0], Parts = new List<Part> { parts[0], parts[1], parts[4] } },
                new Product { Name = "Jack-in Chair", ArticleNumber = "56473829", Manufacturer = "MatrixWorks", Description = "Stoel met een rugsteun en metalen armen...", Stock = 10, Price = 500.50m, Category = categories[1], Parts = new List<Part> { parts[1], parts[2], parts[5] } },
                new Product { Name = "Hovercraft Engine", ArticleNumber = "91827364", Manufacturer = "HoverDynamics", Description = "Aandrijving voor hovercrafts", Stock = 2, Price = 15000.00m, Category = categories[0], Parts = new List<Part> { parts[0], parts[3], parts[7] } },
                new Product { Name = "Power Core", ArticleNumber = "34567123", Manufacturer = "CoreTech", Description = "Energievoorziening voor grote systemen", Stock = 8, Price = 20000.00m, Category = categories[0], Parts = new List<Part> { parts[9], parts[10], parts[19] } },
                new Product { Name = "Stealth Suit", ArticleNumber = "20394857", Manufacturer = "GhostWear", Description = "Onzichtbaarheidsuitrusting", Stock = 12, Price = 7500.00m, Category = categories[2], Parts = new List<Part> { parts[11], parts[12], parts[15] } },
                new Product { Name = "Command Console", ArticleNumber = "65748392", Manufacturer = "ControlX", Description = "Besturingseenheid voor schepen", Stock = 4, Price = 3000.00m, Category = categories[3], Parts = new List<Part> { parts[7], parts[15], parts[16] } },
                new Product { Name = "Docking Clamp", ArticleNumber = "74839210", Manufacturer = "DockSafe", Description = "Veilige koppeling van schepen", Stock = 15, Price = 1200.00m, Category = categories[0], Parts = new List<Part> { parts[1], parts[14], parts[18] } },
                new Product { Name = "Energy Shield", ArticleNumber = "11223344", Manufacturer = "DefendTech", Description = "Beschermt tegen aanvallen", Stock = 3, Price = 50000.00m, Category = categories[2], Parts = new List<Part> { parts[5], parts[9], parts[10], parts[17] } },
                new Product { Name = "Surveillance Drone", ArticleNumber = "55667788", Manufacturer = "SkyView", Description = "Verkenningsdrone", Stock = 20, Price = 1200.00m, Category = categories[2], Parts = new List<Part> { parts[6], parts[13], parts[12] } },
                new Product { Name = "Cryo Chamber", ArticleNumber = "77889911", Manufacturer = "FreezeCorp", Description = "Bewaring in cryo-slaap", Stock = 2, Price = 45000.00m, Category = categories[1], Parts = new List<Part> { parts[8], parts[3], parts[11] } },
                new Product { Name = "Defense Turret", ArticleNumber = "33445566", Manufacturer = "GunWorks", Description = "Automatisch afweergeschut", Stock = 6, Price = 9500.00m, Category = categories[2], Parts = new List<Part> { parts[5], parts[17], parts[6] } },
                new Product { Name = "Medical Pod", ArticleNumber = "88990012", Manufacturer = "MedLife", Description = "Medisch herstelstation", Stock = 7, Price = 8000.00m, Category = categories[1], Parts = new List<Part> { parts[3], parts[8], parts[12] } },
                new Product { Name = "Navigation Computer", ArticleNumber = "22113344", Manufacturer = "NavCore", Description = "Navigatiesysteem voor lange reizen", Stock = 9, Price = 2500.00m, Category = categories[3], Parts = new List<Part> { parts[7], parts[15], parts[16] } },
                new Product { Name = "Repair Robot", ArticleNumber = "99887766", Manufacturer = "FixIt", Description = "Zelfherstellende robot", Stock = 14, Price = 3000.00m, Category = categories[4], Parts = new List<Part> { parts[6], parts[1], parts[13] } },
                new Product { Name = "Security Gate", ArticleNumber = "44556677", Manufacturer = "SafeZone", Description = "Toegangscontrole systeem", Stock = 11, Price = 4000.00m, Category = categories[2], Parts = new List<Part> { parts[16], parts[17], parts[18] } }
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order
                {
                    Customer = customers[0],
                    OrderDate = DateTime.Parse("2021-01-01"),
                    Total = 56.10m,
                    Products = new List<Product> { products[0], products[1] }
                },
                new Order
                {
                    Customer = customers[0],
                    OrderDate = DateTime.Parse("2021-02-01"),
                    Total = 32.59m,
                    Products = new List<Product> { products[1] }
                },
                new Order
                {
                    Customer = customers[1],
                    OrderDate = DateTime.Parse("2021-02-01"),
                    Total = 163.00m,
                    Products = new List<Product> { products[0], products[0] }
                },
                new Order
                {
                    Customer = customers[2],
                    OrderDate = DateTime.Parse("2021-03-01"),
                    Total = 562.99m,
                    Products = new List<Product> { products[1], products[1] }
                }
            };
            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }
}
