using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoList.Modellek;

namespace TodoList.Pages
{
    public class MegcsinaltModel : PageModel
    {
        [BindProperty] //Itt kapjuk meg azt az azonos�t�t, amit be�runk.
        public string Azonosito { get; set; }

        public void OnPost() //Ez az a logika, amivel megcsin�ljuk a teend�t.
        {
            foreach (var teendo in Tarhely.Teendok)
            {
                if(teendo.Id.ToString() == Azonosito)
                {
                    teendo.Megcsinaltae = true; //Itt csin�ljuk meg a teend�t
                }
            }
        }
    }
}
