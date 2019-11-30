using System.Linq;
using Microsoft.EntityFrameworkCore;
using EquiposDeFutbol.Models;

namespace EquiposDeFutbol.Data 
{
    public static class DbInitializer {
        public static void Initializate(EquiposDeFutbolContext context) {
            context.Database.EnsureCreated(); // crea bd si no existe

            if(context.Teams.Any()) {
                return; // la bd ya tiene datos
            }

            // arreglo del tipo FilmGeneres 
            var Teams = new Teams[] {
                new Teams {TeamName="Barsa"},
                new Teams {TeamName="Real madrid"},
                new Teams {TeamName="Juventus"},
                new Teams {TeamName="Chelsea"},
                new Teams {TeamName="Liverpool"},
                
            };
            // pasar el arreglo a la tabla de FilmGeneres en el modelo
            foreach(Teams t in Teams) {
                context.Teams.Add(t);
            }
            //grabar los datos en la bd fisica
            context.SaveChanges();      
        }
    }
} 