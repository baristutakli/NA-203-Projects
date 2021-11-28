using OyunYönetimSistemiAbstraction.Concrete;
using OyunYönetimSistemiAbstraction.Entities;
using System;

namespace OyunYönetimSistemiAbstraction {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User user1 = new User("userName", "mail", "1111111", "firstName", "lastName", "");
            User user2 = new User("userName", "mail", "1111111", "firstName", "lastName", "");
            User user3 = new User("userName", "mail", "1111111", "firstName", "lastName", "");
       

            Corporate peak = new Corporate("userName", "mail", "1111111", "firstName", "lastName", "", "Peak Game");
            Corporate mario = new Corporate("userName", "mail", "1111111", "firstName", "lastName", "", "Mario");
   

            Individual baris = new Individual("userName", "mail", "1111111", "firstName", "lastName", "", new MemberShip("Gold"));
            Individual bob = new Individual("userName", "mail", "1111111", "firstName", "lastName", "", new MemberShip("Argent"));

            SalesManager salesManager = new SalesManager();
            SalesManager salesManager1 = new SalesManager();

            CampaignManager campaignManager = new CampaignManager();
            CampaignManager campaignManager2 = new CampaignManager();

            UserManager userManager = new UserManager();
            UserManager userManager2 = new UserManager();

        }

    }
}
