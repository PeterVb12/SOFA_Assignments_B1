// See https://aka.ms/new-console-template for more information
using Bioscoop.Domain;
using System.Linq.Expressions;

Movie inception = new Movie("Inception");
Movie godfather = new Movie("The Godfather");
Movie oppenheimer = new Movie("Oppenheimer");

MovieScreening inception1  = new MovieScreening(inception, new DateTime(2025, 2, 9), 10.0);

MovieTicket ticket1 = new MovieTicket(inception1, false, 1, 1);
MovieTicket ticket2 = new MovieTicket(inception1 , false, 1, 2);

Order order1 = new Order(1, false);
order1.addSeatReservation(ticket1);
order1.addSeatReservation(ticket2);

Console.WriteLine(order1.calculatePrice());


    


