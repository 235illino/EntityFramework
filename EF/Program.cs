﻿using EF;

using var context = new SchoolContext();


//using (var context = new SchoolDbContext())
//{
//    creates db if not exists
//    context.Database.EnsureCreated();

//    create entity objects
//    var grd1 = new Grade() { GradeName = "1st Grade" };
//    var std1 = new Student() { FirstName = "Yash", LastName = "Malhotra", Grade = grd1 };

//    add entitiy to the context
//    context.Students.Add(std1);

//    save data to the database tables
//    context.SaveChanges();

//    retrieve all the students from the database
//    foreach (var s in context.Students)
//    {
//        Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
//    }
//}

