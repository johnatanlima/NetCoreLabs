using System;
using efconsole.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace efconsole
{
    class Program
    {
        static void Main(string[] args)
        {
           //  Console.WriteLine("Hello World!");

           // -> TRAZER E MOSTRAR OS ID E NOME DA TABELA ATOR

            var dbContext = new sakilaContext();
            var actors = dbContext.Actor.ToList();
           
            foreach (var a in actors) {
                System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            }
            
            
            /*
                ->> TRAZ O NOME DO FILME E ABAIXO O NOME DOS ATORES DO FILME

             var dbContext = new sakilaContext();
            var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
            
            foreach (var record in records) {
            System.Console.WriteLine($"Film: {record.Title}");
            var counter = 1;
            foreach (var fa in record.FilmActor) {
                System.Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
              }
            } */
          
           /*  
                -->> ADICIONADO A CIDADE PIRACITY
           var dbContext = new sakilaContext();

            var city = new City() { CityId = 1001, City1 = "PiraCity", CountryId = 103 };
            dbContext.Add(city);
            dbContext.SaveChanges(); */

            /* 
                    -->> ATUALIZOU A CIDADE QUE FOI INSERIDA ANTERIORMENTE

            var dbContext = new sakilaContext();

            var uTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
            if (uTarget != null) {
            uTarget.City1 = "Piracicaba";  // change Name to City1 if you did not update the City class file
            dbContext.Update(uTarget);
            dbContext.SaveChanges();
            } */
            
            /* 
                ->> DELETOU A CIDADE ANTERIORMENTE INSERIDA NA BASE DE DADOS
            var dbContext = new sakilaContext();

            var dTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
                if (dTarget != null) {
                    dbContext.Remove(dTarget);
                    dbContext.SaveChanges();
                }
            */
        }
    }
}
