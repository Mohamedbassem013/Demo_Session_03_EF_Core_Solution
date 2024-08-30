using Demo_Session_03_EF_Core.Context;
using Demo_Session_03_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
internal class Program
{
    private static void Main(string[] args)
    {
        #region Inheritance Example
        // 1. TPC
        // 2. TPH
        // 3. TPCC

        //using AppDbContext Context = new AppDbContext();
        //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
        //{
        //    Name = "Ahmed Ali",
        //    Address = "Cario",
        //    Email = "Ahmed@gmail.com",
        //    Salary = 12000
        //};
        //Context.fullTimeEmployees.Add(fullTimeEmployee);
        //Context.partTimeEmployees.Add(PartTimeEmployee);

        //Context.employees.Add(fullTimeEmployee);
        //Context.fullTimeEmployees.Add(fullTimeEmployee);

        //var result = Context.employees.OfType<FullTimeEmployee>();
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.Name);
        //}

        //Context.fullTimeEmployees.Add(fullTimeEmployee);
        //Context.SaveChanges();

        #endregion

        #region Loading of Navigational
        using AppDbContext Context = new AppDbContext();

        // EF Core Don't Loading The Navigational Property

        //var employee = Context.employees.FirstOrDefault( E => E.Id == 2 );

        //Console.WriteLine(employee?.Id ?? 0);
        //Console.WriteLine(employee?.Name ?? "NA");
        //Console.WriteLine(employee?.Salary ?? 0);
        //Console.WriteLine(employee?.Address ?? "Na");
        //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

        //var department = Context.departments.FirstOrDefault(D => D.Id == 1);

        //Console.WriteLine(department?.Id ?? 0);
        //Console.WriteLine(department?.Name ?? "NA");

        //foreach (var item in department.employees)
        //{
        //    Console.WriteLine(item.Name);
        //}

        // Loading To The Navigational Property :
        // 1. Explicit Loading
        // 2. Eager Loading
        // 3. Lazy Loading
        #endregion

        #region Explicit Loading

        //var employee = Context.employees.FirstOrDefault( E => E.Id == 2 );

        // Context.Entry(employee).Reference("WorkFor").Load(); // Loading of Navigational Property Explicitly
        //Context.Entry(employee).Reference(E => E.WorkFor).Load(); // Loading of Navigational Property Explicitly 


        //Console.WriteLine(employee?.Id ?? 0);
        //Console.WriteLine(employee?.Name ?? "NA");
        //Console.WriteLine(employee?.Salary ?? 0);
        //Console.WriteLine(employee?.Address ?? "Na");
        //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

        //var department = Context.departments.FirstOrDefault(D => D.Id == 1);
        //Context.Entry(department).Collection("Employees").Load();

        //Console.WriteLine(department?.Id ?? 0);
        //Console.WriteLine(department?.Name ?? "NA");

        //foreach (var item in department.employees)
        //{
        //    Console.WriteLine(item.Name);
        //}
        #endregion

        #region Eager Loading

        //var employee = Context.employees.Include("WorkFor").FirstOrDefault( E => E.Id == 2 );
        //var employee = Context.employees.Include( E => E.WorkFor ).Include( E => E.Salary ).FirstOrDefault(E => E.Id == 2);

        //Console.WriteLine(employee?.Id ?? 0);
        //Console.WriteLine(employee?.Name ?? "NA");
        //Console.WriteLine(employee?.Salary ?? 0);
        //Console.WriteLine(employee?.Address ?? "Na");
        //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

        //var department = Context.departments.Include(D => D.employees).Include().FirstOrDefault(D => D.Id == 1);

        //Console.WriteLine(department?.Id ?? 0);
        //Console.WriteLine(department?.Name ?? "NA");

        //foreach (var item in department.employees)
        //{
        //    Console.WriteLine(item.Name);
        //}

        #endregion

        #region Lazy Loading

        // Lazy Loading [ Implicitly ]


        // 1. Install-Package Proxies
        // 2. UseLazyLoadingProxies() in OnConfiguring()
        // 3. Make All The Entites Public
        // 4. Make All The Navigational Property Virtual


        //var employee = Context.employees.Include("WorkFor").FirstOrDefault( E => E.Id == 2 );
        //var employee = Context.employees.Include( E => E.WorkFor ).Include( E => E.Salary ).FirstOrDefault(E => E.Id == 2);

        //Console.WriteLine(employee?.Id ?? 0);
        //Console.WriteLine(employee?.Name ?? "NA");
        //Console.WriteLine(employee?.Salary ?? 0);
        //Console.WriteLine(employee?.Address ?? "Na");
        //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

        //var department = Context.departments.FirstOrDefault(D => D.Id == 1);
        //var result = Context.students;

        //Console.WriteLine(department?.Id ?? 0);
        //Console.WriteLine(department?.Name ?? "NA");

        //foreach (var item in department.employees)
        //{
        //    Console.WriteLine(item.Name);
        //}


        #endregion

        #region Join Operators 

        // Join Operators : join

        //using AppDbContext AppContext = new AppDbContext();

        //// Fluent Syntax

        //var Result = Context.employees.Join(Context.departments,
        //                                  E => E.Id,
        //                                  D => D.Id,
        //                                  (E, D) => new
        //                                  {
        //                                      EmpId = E.Id,
        //                                      EmpName = E.Name,
        //                                      DeptId = D.Id,
        //                                      DeptNams = D.Name
        //                                  });
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        //// PK = FK 



        //// Query Syntax
        //Result = from E in Context.employees
        //         join D in Context.departments
        //         on E.DeptId equals D.Id
        //         select new
        //         {
        //             EmpId = E.Id,
        //             EmpName = E.Name,
        //             DeptId = D.Id,
        //             DeptNams = D.Name
        //         };
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Tracking Vs NoTracking

        // Tracking Vs NoTracking
        // Tracking [Default]

        //using AppDbContext AppContext = new AppDbContext();

        //var employee = Context.employees.FirstOrDefault(E => E.Id == 2);

        // NoTracking
        //var employee1 = Context.employees.AsNoTracking().FirstOrDefault(E => E.Id == 2);

        //Console.WriteLine(Context.Entry(employee).State);// Detached

        //employee.Name = "Ali"; // Local

        //Console.WriteLine(Context.Entry(employee).State); // Local

        //Console.WriteLine(employee.Name);

        //Context.SaveChanges(); // Remotly
        #endregion

        #region Remote Vs Local

        //  Remote Vs Local

        using AppDbContext AppContext = new AppDbContext();
        Context.employees.Load();

        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();
        Context.employees.Local.Any();

        #endregion




    }
}