using Entity_Framework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    class Program
    {
        public static void Add3Hotels()
        {
            //1) Add 3 hotels to DB, one with name 'Edelweiss'
            using (var context = new HotelsContext())
            {
                var bykovina = new Hotels()
                {
                    name = "Bykovina",
                    foundationYear = 2003,
                    address = "Chernivtsi, st. Holovna 110",
                    isActive = true
                }; 

                 var edelweiss = new Hotels()
                {
                    name = "Edelweiss",
                    foundationYear = 2013,
                    address = "Chernivtsi, st. Holovna 34",
                    isActive = true

                };
                var cheremosh = new Hotels()
                {
                    name = "Cheremosh",
                    foundationYear = 2000,
                    address = "Chernivtsi, st. Komarova 43",
                    isActive = true

                };
                context.Hotels.Add(bykovina);
                context.Hotels.Add(edelweiss);
                context.Hotels.Add(cheremosh);
                context.SaveChanges();
            }
        }
         
        public static void GetAllHotels()
        {
            //2)Get All hotels from DB
            using (var db = new HotelsContext())
            {
                var hotels = db.Hotels.Select(x => x).ToList();
                foreach (var hotel in hotels)
                {

                    Console.WriteLine($"{hotel.hotelsID} - {hotel.name} - {hotel.foundationYear} - {hotel.address} - {hotel.isActive}");
                    continue;                    
                }
                Console.ReadKey();
            }
        }
        public static void UpdateFirstHotel()
        {
            //3) Update first hotel foundation year from existing value to 1937
            using (var hotelsContext = new HotelsContext())
            {
                var hotel = hotelsContext.Hotels.First<Hotels>();
                hotel.foundationYear = 1937;
                hotelsContext.SaveChanges();
            }
        }

        public static void DeleteThirdHotel()
        {
            //4)Delete 3d hotel from DB by Id:
            using (var hotelsContext = new HotelsContext())
            {
                var hotel = hotelsContext.Hotels.Find(7);
                hotelsContext.Hotels.Remove(hotel);
                hotelsContext.SaveChanges();
            }
        }

        public static void InsertTenUsers()
        {
            /*5)Insert 10 users to Database, but have at least 2 users with Name Andrew or Anton:*/
            using (var context = new HotelsContext())
            {
                var ivanov = new Users()
                {
                    firstName = "Andrew",
                    lastName = "Ivanov",
                    email = "Ivanov@gmail.com"
                };
                var petrov = new Users()
                {
                    firstName = "Anton",
                    lastName = "Petrov",
                    email = "Petrov@gmail.com"
                };
                var panchenko = new Users()
                {
                    firstName = "Boris",
                    lastName = "Panchenko",
                    email = "Panchenko@gmail.com"
                };
                var sytnyk = new Users()
                {
                    firstName = "Nazar",
                    lastName = "Sytnyk",
                    email = "Sytnyk@gmail.com"
                };
                var lavrinok = new Users()
                {
                    firstName = "Ira",
                    lastName = "Lavrinok",
                    email = "Lavrinok@gmail.com"
                };
                var pislar = new Users()
                {
                    firstName = "Max",
                    lastName = "Pislar",
                    email = "Pislar@gmail.com"
                };
                var fediv = new Users()
                {
                    firstName = "Misha",
                    lastName = "Fediv",
                    email = "Fediv@gmail.com"
                };
                var deretorska = new Users()
                {
                    firstName = "Tania",
                    lastName = "Deretorska",
                    email = "Deretorska@gmail.com"
                };
                var dreneyka = new Users()
                {
                    firstName = "Max",
                    lastName = "Dreneyka",
                    email = "Dreneyka@gmail.com"
                };
                var fors = new Users()
                {
                    firstName = "Ivan",
                    lastName = "Fors",
                    email = "Fors@gmail.com"
                };

                context.Users.AddRange(new List<Users>() { ivanov, petrov, panchenko, panchenko, sytnyk, panchenko, pislar, fediv, deretorska, dreneyka, fors });
                context.SaveChanges();
            }
        }
        public static void GetAllUserWhichNameStartsFromA()
        {
            //6) Get all users which name starts from "A"
            using (var db = new HotelsContext())
            {
                var users = db.Users.Select(x => x).Where(n => n.firstName.ToUpper().StartsWith("A")).ToList();
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.firstName} - {user.lastName} - {user.email}");
                    continue;
                }
                Console.ReadKey();
            }
        }
        public static void InsertTenRooms()
        {
            /*7) Insert 10 rooms in DB. 7 to first hotel and 3 to other. Make sure both hotels have room number 101. Make sure 'Edelweiss' has room number 301, but other hotel no.
               Also make sure 'Edelweiss' do not have rooms with comfort level 3, but second hotel has at least one room with such comfort level*/
            using (var context = new HotelsContext())
            {
                var first = new Rooms()
                {
                    hotelsID = 9,
                    number = 101,
                    price = 400,
                    comfortLevel = 1,
                    capability = 2
                };
                var second = new Rooms()
                {
                    hotelsID = 9,
                    number = 102,
                    price = 500,
                    comfortLevel = 2,
                    capability = 4
                };
                var third = new Rooms()
                {
                    hotelsID = 9,
                    number = 103,
                    price = 750,
                    comfortLevel = 2,
                    capability = 3
                };
                var fourth = new Rooms()
                {
                    hotelsID = 9,
                    number = 104,
                    price = 400,
                    comfortLevel = 1,
                    capability = 2
                };
                var fifth = new Rooms()
                {
                    hotelsID = 9,
                    number = 201,
                    price = 500,
                    comfortLevel = 2,
                    capability = 4
                };
                var sixth = new Rooms()
                {
                    hotelsID = 9,
                    number = 202,
                    price = 250,
                    comfortLevel = 1,
                    capability = 3
                };
                var seventh = new Rooms()
                {
                    hotelsID = 9,
                    number = 301,
                    price = 430,
                    comfortLevel = 1,
                    capability = 2
                };
                var eighth = new Rooms()
                {
                    hotelsID = 5,
                    number = 101,
                    price = 520,
                    comfortLevel = 2,
                    capability = 1
                };
                var nineth = new Rooms()
                {
                    hotelsID = 5,
                    number = 102,
                    price = 950,
                    comfortLevel = 2,
                    capability = 3
                };
                var tenth = new Rooms()
                {
                    hotelsID = 5,
                    number = 103,
                    price = 1150,
                    comfortLevel = 3,
                    capability = 3
                };
                context.Rooms.AddRange(new List<Rooms>() { first, second, third, fourth, fifth, sixth, seventh });
                context.SaveChanges();
            }
        }

        public static void SelectAllRoomsSortedByPrice()
        {
            /*8) Select All rooms from DB sorted by Price*/
            using (var db = new HotelsContext())
            {
                var rooms = db.Rooms.Select(x => x).OrderBy(o => o.price).ToList();
                foreach (var room in rooms)
                {
                    Console.WriteLine($"{room.roomsID} - {room.hotelsID} - {room.number} - {room.price} - {room.comfortLevel} - {room.capability}");
                    continue;
                }
                Console.ReadKey();
            }
        }

        public static void SelectBykovinaAndSortedByPrice()
        {
            /*9) Select All rooms from DB that belong to 'Bykovina' hotel and sorted by price*/
            using (var db = new HotelsContext())
            {
                var rooms = db.Rooms.Join(db.Hotels,
                    p => p.hotelsID,
                    c => c.hotelsID,
                    (p, c) => new
                    {
                        Id = p.hotelsID,
                        Name = c.name,
                        Price = p.price
                    }).Select(x => x).Where(n => n.Name == "Bykovina").OrderBy(o => o.Price).ToList();
                foreach (var room in rooms)
                {
                    Console.WriteLine($"{room.Id} - {room.Name} - {room.Price}");
                    continue;
                }
                Console.ReadKey();
            }
        }
        public static void SelectHotelsWithComfortLevel3()
        {
            /*10) Select Hotels that have rooms with comfort level 3*/
            using (var db = new HotelsContext())
            {
                var hotels = db.Hotels.Join(db.Rooms,
                    p => p.hotelsID,
                    c => c.hotelsID,
                    (p, c) => new
                    {
                        Id = p.hotelsID,
                        ComfortLevel = c.comfortLevel,
                        Name = p.name
                    }).Select(x => x).Where(n => n.ComfortLevel == 3).ToList();
                foreach (var hotel in hotels)
                {
                    Console.WriteLine($"{hotel.Id} - {hotel.ComfortLevel} - {hotel.Name}");
                    continue;
                }
                Console.WriteLine();
            }
        }

        public static void SelectHotelNameAndRoomNumberThatHaveComfortLevel2()
        {
            /*11) Select Hotelname and room number for rooms that have comfort level 2*/
            using (var db = new HotelsContext())
            {
                var hotels = db.Hotels.Join(db.Rooms,
                    p => p.hotelsID,
                    c => c.hotelsID,
                    (p, c) => new
                    {
                        Id = p.hotelsID,
                        Number = c.number,
                        ComfortLevel = c.comfortLevel,
                        Name = p.name
                    }).Select(x => x).Where(n => n.ComfortLevel == 2).ToList();
                foreach (var hotel in hotels)
                {
                    Console.WriteLine($"{hotel.Id} - {hotel.Number} - {hotel.Name} - {hotel.ComfortLevel}");
                    continue;
                }
                Console.ReadKey();
            }
        }
        public static void SelectHotelNameAndCountOfHotelsRooms()
        {
            /* 12) Select Hotel names and count of hotel rooms*/
            using (var db = new HotelsContext())
            {
                var hotels = db.Hotels.Join(db.Rooms,
                    p => p.hotelsID,
                    c => c.hotelsID,
                    (p, c) => new
                    {
                        Count = db.Rooms.Select(x => x).Where(n => n.hotelsID == 9).Count(),
                        Name = p.name
                    }).Select(x => x).ToList();
                var groups = hotels.GroupBy(g => g.Name);
                foreach (var group in groups)
                {
                    Console.Write($"{group.Key} ");
                    foreach (var hotel in hotels)
                    {
                        Console.WriteLine($"{hotel.Count}");
                        break;
                    }
                }
                Console.ReadKey();
            }
        }

        public static void InsertTenRezervations()
        {
            /* 13) Insert 10 different reservations to db.*/
            using (var context = new HotelsContext())
            {
                var rezervation1 = new Rezervation()
                {
                    roomsID = 1,
                    usersID = 2,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation2 = new Rezervation()
                {
                    roomsID = 2,
                    usersID = 4,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation3 = new Rezervation()
                {
                    roomsID = 6,
                    usersID = 2,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation4 = new Rezervation()
                {
                    roomsID = 4,
                    usersID = 1,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation5 = new Rezervation()
                {
                    roomsID = 5,
                    usersID = 8,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation6 = new Rezervation()
                {
                    roomsID = 4,
                    usersID = 6,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation7 = new Rezervation()
                {
                    roomsID = 2,
                    usersID = 7,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation8 = new Rezervation()
                {
                    roomsID = 8,
                    usersID = 3,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation9 = new Rezervation()
                {
                    roomsID = 9,
                    usersID = 9,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                var rezervation10 = new Rezervation()
                {
                    roomsID = 6,
                    usersID = 2,
                    startRezervation = DateTime.Parse("2018 - 05 - 25"),
                    endRezervation = DateTime.Parse("2018 - 05 - 27")
                };
                context.Rezervations.AddRange(new List<Rezervation>() { rezervation1, rezervation2, rezervation3, rezervation4, rezervation5, rezervation6, rezervation7, rezervation8, rezervation9, rezervation10 });
                context.SaveChanges();
            }
        }
        public static void SelectUserNameRoomNumberRezervationPeriod()
        {
            //14) Select Username, room number, reservation period.
            using (var db = new HotelsContext())
            {
                var result = db.Rezervations.Join(db.Rooms,
                p => p.roomsID,
                c => c.roomsID,
                (p, c) => new
                {
                    StartRezervation = p.startRezervation,
                    EndRezervation = p.endRezervation,
                    Number = c.number,
                    UsersId = p.usersID
                })
                .Join(db.Users,
                 p => p.UsersId,
                c => c.usersID,
                (p, c) => new
                {
                    Start = p.StartRezervation,
                    End = p.EndRezervation,
                    Number = p.Number,
                    Name = c.firstName + c.lastName
                });
                foreach (var query in result)
                    Console.WriteLine($"{query.Name} - {query.Number} - {query.Start} - {query.End}");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Add3Hotels();
            GetAllHotels();
            UpdateFirstHotel();
            DeleteThirdHotel();
            InsertTenUsers();
            GetAllUserWhichNameStartsFromA();
            InsertTenRooms();
            SelectAllRoomsSortedByPrice();
            SelectBykovinaAndSortedByPrice();
            SelectHotelsWithComfortLevel3();
            SelectHotelNameAndRoomNumberThatHaveComfortLevel2();
            SelectHotelNameAndCountOfHotelsRooms();
            InsertTenRezervations();
            SelectUserNameRoomNumberRezervationPeriod();
        }
    }
}
