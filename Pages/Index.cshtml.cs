using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class IndexModel : PageModel
{
    [BindProperty]
    [Display(Name = "Radius (r) [cm]")]
    [Range(0.000001, double.MaxValue, ErrorMessage = "Radius must be greater than 0.")]
    public double Radius { get; set; }

    [BindProperty]
    [Display(Name = "Height (h) [cm]")]
    [Range(0.000001, double.MaxValue, ErrorMessage = "Height must be greater than 0.")]
    public double Height { get; set; }

    public double? Volume { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        // Correct formula with proper variable name
        Volume = (2.0 / 3.0) * Radius * Radius * Height;
    }
}
