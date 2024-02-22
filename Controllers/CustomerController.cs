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

}

