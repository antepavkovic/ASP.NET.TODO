using ASP.NET.TODO.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Reflection.Metadata.BlobBuilder;

namespace ASP.NET.TODO.Repository
{
    public class TodoRepository
    {
        private static List<Todo> todo;
        public TodoRepository()
        {
            if (todo == null)
            {
                todo = new List<Todo>();
                SimulateDatabase();

            }
        }
        public List<Todo> GetTodos()
        {
            return todo;
        }
        private void SimulateDatabase()
        {
            todo.Add(new Todo()
            {
                ID = 1,
                Naziv = "Probudi se na prvi zvuk alarma",
                Rok = new DateTime(2023, 1, 1)
            });
            todo.Add(new Todo()
            {
               
            
                ID = 2,
                Naziv = "Doručkuj!",
                Rok = new DateTime(2022,2,14)
          
        });
          todo.Add(new Todo()
        {
                ID = 3,
                Naziv = "Obavi šoping!",
                Rok = new DateTime(2023, 2,11)
            });

            todo.Add(new Todo()
            {
                ID = 4,
                Naziv = "Kreni na posao",
                Rok = new DateTime(2022,1,4)
            });

            todo.Add(new Todo()
            {
                ID = 5,
                Naziv = "Sastanak!",
                Rok = new DateTime(2023, 5,2)
            });
        }
    }

}
