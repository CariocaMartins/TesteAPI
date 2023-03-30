using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CalcularFatorial : ControllerBase
    {
        [Route("/")]
        [HttpGet]
public string Calcular([FromQuery] int number)
{
    if (number < 0)
    {
        return "O número deve ser maior ou igual a zero";
    }
    
    int fatorial = 1;
    string conta = "1";

    for (int i = 2; i <= number; i++)
    {
        fatorial *= i;
        conta += " * " + i;
    }

    return $"{conta} = {fatorial}";
}


    }

}