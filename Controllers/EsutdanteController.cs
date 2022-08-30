using Microsoft.AspNetCore.Mvc;
using MvcRazorView.ViewModels;
namespace MvcRazorView.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = 
    new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Maria Da Silva", "Rua x, 1", true),
        new EstudanteViewModel(2, "Pedro Moreira", "Rua y, 1", true),
        new EstudanteViewModel(3, "Felipe Gonzaga", "Rua z, 3", false),
        new EstudanteViewModel(4, "Luís Duarte", "Rua c, 3", true)
    };
    public IActionResult Index(){
        return View(estudantes);
    }
    public IActionResult Show(int id){
        return View(estudantes[0]);
    }
}