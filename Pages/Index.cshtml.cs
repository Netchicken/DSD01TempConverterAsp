using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace DSD01TempConverterAsp.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        public float Celsius { get; set; }

        [Display(Name = "Fahrenheit")]

        public float Fah { get; set; }
        public string? Answer { get; set; }


        public void OnPost()
        {

            if (Celsius > 0)
            {
                Fah = ((float)(Celsius * (9.0 / 5.0) + 32));
                Answer = Celsius.ToString() + " Celsius converted to " + Fah.ToString() + " Fahrenheit";
            }

            else if (Fah > 0)
            {
                Celsius = (float)((5.0 / 9.0) * (Fah - 32.0));
                Answer = Fah.ToString() + " Fahrenheit  converted to " + Celsius.ToString() + " Celsius";
            }




        }




        public void OnGet()
        {

        }
    }
}