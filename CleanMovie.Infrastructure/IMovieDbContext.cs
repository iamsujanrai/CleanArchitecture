using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public interface IMovieDbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Rental> Rentals { get; set; }
        DbSet<Member> Members { get; set; }
        DbSet<MovieRental> MovieRentals { get; set; }
    }
}
