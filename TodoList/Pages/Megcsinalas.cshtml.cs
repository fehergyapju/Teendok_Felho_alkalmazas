using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoList.Modellek;

namespace TodoList.Pages
{
    public class MegcsinaltModel : PageModel
    {
        [BindProperty] //Itt kapjuk meg azt az azonosítót, amit beírunk.
        public string Azonosito { get; set; }

        public void OnPost() //Ez az a logika, amivel megcsináljuk a teendõt.
        {
            foreach (var teendo in Tarhely.Teendok)
            {
                if(teendo.Id.ToString() == Azonosito)
                {
                    teendo.Megcsinaltae = true; //Itt csináljuk meg a teendõt
                }
            }
        }
    }
}
