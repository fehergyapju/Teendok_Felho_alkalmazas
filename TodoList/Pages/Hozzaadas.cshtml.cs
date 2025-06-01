using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoList.Modellek;

namespace TodoList.Pages
{
    public class HozzaadasModel : PageModel
    {
        [BindProperty] //Ha rámegyünk a mentés gombra, akkor ezzel fogja megtalálni, hogy ide menti a leírást amit beírtunk.
        public string Cim {  get; set; }

        [BindProperty]
        public DateTime Datum { get; set; } = DateTime.Now; //Beállítja a mostani idõt a naptárnak.

        public void OnPost() //Ez a logika fog lefutni, ha rámentünk a mentés gombra
        {
            Teendo ujTeendo = new Teendo();

            ujTeendo.Leiras = Cim;

            ujTeendo.Idopont = Datum;

            Tarhely.Teendok.Add(ujTeendo);
        }
    }
}
