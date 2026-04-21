using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty] public double Length1 { get; set; }
    [BindProperty] public double Width1 { get; set; }
    [BindProperty] public double Height1 { get; set; }

    [BindProperty] public double Length2 { get; set; }
    [BindProperty] public double Width2 { get; set; }
    [BindProperty] public double Height2 { get; set; }

    [BindProperty] public double Length3 { get; set; }
    [BindProperty] public double Width3 { get; set; }
    [BindProperty] public double Height3 { get; set; }

    public double TotalVolume { get; set; }

    public void OnPost()
    {
        double v1 = Length1 * Width1 * Height1;
        double v2 = Length2 * Width2 * Height2;
        double v3 = Length3 * Width3 * Height3;

        TotalVolume = v1 + v2 + v3;
    }
}