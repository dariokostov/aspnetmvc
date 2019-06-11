using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homewokr.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homewokr.Controllers
{
    public class MovieController : Controller
    {
        public static List<MovieModel> MoviesList = new List<MovieModel>
        {
            new MovieModel{
                Id = 1,
                Name = "Interstellar",
                Genre = "SciFi",
                Rating = 8.8,
                Length = 124
            },
            new MovieModel{
                Id = 2,
                Name = "The Upside",
                Genre = "Drama",
                Rating = 6.7,
                Length = 110
            },
            new MovieModel{
                Id = 3,
                Name = "Guardians of the galaxy",
                Genre = "SciFi",
                Rating = 7.9,
                Length = 113
            },
            new MovieModel{
                Id = 4,
                Name = "Up",
                Genre = "Animation",
                Rating = 8.7,
                Length = 129
            },

        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View(MoviesList);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult MovieDetails(MovieModel model)
        {
            var movie = MoviesList.FirstOrDefault(m => m.Id == model.Id);
            return View(movie);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieModel movie)
        {
            MoviesList.Add(movie);
            return View("Movies", MoviesList);
        }

        public IActionResult Edit(int id)
        {
            var movie = MoviesList.FirstOrDefault(m => m.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult UpdateMovie(MovieModel movie)
        {
            var movieIndex = MoviesList.FindIndex(m => m.Id == movie.Id);
            MoviesList[movieIndex] = movie;
            return View("Movies", MoviesList);
        }

        public IActionResult Remove(int id)
        {
            var movie = MoviesList.FirstOrDefault(m => m.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult RemoveMovie(MovieModel movie)
        {
            MoviesList.Remove(MoviesList[movie.Id]);

            return View("Movies", MoviesList);
        }
    }
}