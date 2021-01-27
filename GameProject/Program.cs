using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEstateUserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1, 
                BirthYear = 1985, 
                FirstName = "ENGİN", 
                LastName = "DEMİR", 
                IdentityNumber = 12345 });

            
        }
    }
}
