using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_crud.Models;

namespace dotnet_crud.Controllers;


public class CustomerController : Controller
{
    private readonly ApplicationDbContext _db;

    public CustomerController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var customers = _db.Customers.ToList();
        return View(customers);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddCustomer(Customer customer)
    {
        if (ModelState.IsValid)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(customer);
    }

}

