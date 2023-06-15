using Romanage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Data
{
    public static class ApplicationDbContext
    {
        public static List<User> Users { get; set; }
        public static List<UserEvent> UserEvents { get; set; }

        public static List<Event> Events { get; set; }
        public  static List<Payment> Payments { get; set; }
        public static List<UserRole> UserRoles { get; set; }

        static ApplicationDbContext()
        {
            Users = new List<User>();

            User user = new User();

            user.Name = "Terlan";
            user.Surname = "Usubov";
            user.Email = "admin";
            user.Phone = "";
            user.Created = DateTime.Now;
            user.Updated = DateTime.Now;

            SHA256 sha256 = SHA256.Create();

            byte[] buffer = Encoding.UTF8.GetBytes("admin");

            byte[] hash = sha256.ComputeHash(buffer);

            string base64password = Convert.ToBase64String(hash);

            user.Password = base64password;


            Users.Add(user);



            Events = new List<Event>();

            Event myevent = new Event();

            myevent.Name = "Dolu kadehi ters tut";
            myevent.Price = 30;
            myevent.Address = "Baki konqres merkezi";
            myevent.TicketLimit = 10;
            myevent.Created = DateTime.Now;
            myevent.Updated = DateTime.Now;
            myevent.EventDate = DateTime.Now.AddDays(6);
            myevent.EventStatusId = 10;



            Event myevent2 = new Event();

            myevent2.Name = "Dolu kadehi ters tutma";
            myevent2.Price = 35;
            myevent2.Address = "Baki konqres merkezi deyil";
            myevent2.TicketLimit = 10;
            myevent2.Created = DateTime.Now;
            myevent2.Updated = DateTime.Now;
            myevent2.EventDate = DateTime.Now.AddDays(6);
            myevent2.EventStatusId = 10;


            Event myevent3 = new Event();

            myevent3.Name = "Dolu kadehi ters tutma";
            myevent3.Price = 35;
            myevent3.Address = "Baki konqres merkezi deyil";
            myevent3.TicketLimit = 10;
            myevent3.Created = DateTime.Now;
            myevent3.Updated = DateTime.Now;
            myevent3.EventDate = DateTime.Now.AddDays(6);
            myevent3.EventStatusId = 10;


            Event myevent4 = new Event();

            myevent4.Name = "Dolu kadehi ters tutma";
            myevent4.Price = 35;
            myevent4.Address = "Baki konqres merkezi deyil";
            myevent4.TicketLimit = 10;
            myevent4.Created = DateTime.Now;
            myevent4.Updated = DateTime.Now;
            myevent4.EventDate = DateTime.Now.AddDays(6);
            myevent4.EventStatusId = 10;

            Event myevent5 = new Event();

            myevent5.Name = "Dolu kadehi ters tutma";
            myevent5.Price = 35;
            myevent5.Address = "Baki konqres merkezi deyil";
            myevent5.TicketLimit = 10;
            myevent5.Created = DateTime.Now;
            myevent5.Updated = DateTime.Now;
            myevent5.EventDate = DateTime.Now.AddDays(6);
            myevent5.EventStatusId = 10;

            Event myevent6 = new Event();

            myevent6.Name = "Dolu kadehi ters tutma";
            myevent6.Price = 35;
            myevent6.Address = "Baki konqres merkezi deyil";
            myevent6.TicketLimit = 10;
            myevent6.Created = DateTime.Now;
            myevent6.Updated = DateTime.Now;
            myevent6.EventDate = DateTime.Now.AddDays(6);
            myevent6.EventStatusId = 10;


            Event myevent7 = new Event();

            myevent7.Name = "Dolu kadehi ters tutma";
            myevent7.Price = 35;
            myevent7.Address = "Baki konqres merkezi deyil";
            myevent7.TicketLimit = 10;
            myevent7.Created = DateTime.Now;
            myevent7.Updated = DateTime.Now;
            myevent7.EventDate = DateTime.Now.AddDays(6);
            myevent7.EventStatusId = 10;

            Event myevent8 = new Event();

            myevent8.Name = "Dolu kadehi ters tutma";
            myevent8.Price = 35;
            myevent8.Address = "Baki konqres merkezi deyil";
            myevent8.TicketLimit = 10;
            myevent8.Created = DateTime.Now;
            myevent8.Updated = DateTime.Now;
            myevent8.EventDate = DateTime.Now.AddDays(6);
            myevent8.EventStatusId = 10;

            Events.Add(myevent);
            Events.Add(myevent2);
            Events.Add(myevent3);
            Events.Add(myevent4);
            Events.Add(myevent5);
            Events.Add(myevent6);
            Events.Add(myevent7);
            Events.Add(myevent8);
        }

    }
}
