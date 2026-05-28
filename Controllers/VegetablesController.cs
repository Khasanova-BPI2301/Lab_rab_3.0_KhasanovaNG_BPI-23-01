using Lab_rab_3._0_KhasanovaNG_BPI_23_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_rab_3._0_KhasanovaNG_BPI_23_01.Controllers
{
    public class VegetablesController : Controller
    {
        // Метод для обычного списка (из методички)
        public IActionResult FirstViewMethod()
        {
            List<Vegetable> veggies = new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" } ,
                new Vegetable { Id = 5, Name = "Помидор" }

            };

            // Передаём список в представление
            return View(veggies);
        }

        // Метод для отсортированного списка (из методички)
        public IActionResult SecondViewMethod()
        {
            List<Vegetable> veggies = new List<Vegetable>
            {
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" },
                new Vegetable { Id = 5, Name = "Помидор" }
            };

            // Сортировка по алфавиту
            var sorted = veggies.OrderBy(v => v.Name).ToList();
            return View(sorted);
        }

        // Метод для группировки овощей по первой букве
        public IActionResult ThirdViewMethod()
        {
            List<Vegetable> veggies = new List<Vegetable> 
            {   
                new Vegetable { Id = 1, Name = "Картофель" },
                new Vegetable { Id = 2, Name = "Морковь" },
                new Vegetable { Id = 3, Name = "Лук" },
                new Vegetable { Id = 4, Name = "Капуста" },
                new Vegetable { Id = 5, Name = "Свекла" },
                new Vegetable { Id = 5, Name = "Помидор" }

            };
    

            // Группируем по первой букве и сортируем
            var grouped = veggies.GroupBy(v => v.Name[0])
                                 .OrderBy(g => g.Key)
                                 .ToList();

            return View(grouped);
        }
    }
}
