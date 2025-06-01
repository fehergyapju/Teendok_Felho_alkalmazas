using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoList.Modellek;

namespace TodoList.Pages
{
    public class HozzaadasModel : PageModel
    {
        [BindProperty] //Ha r�megy�nk a ment�s gombra, akkor ezzel fogja megtal�lni, hogy ide menti a le�r�st amit be�rtunk.
        public string Cim {  get; set; }

        [BindProperty]
        public DateTime Datum { get; set; } = DateTime.Now; //Be�ll�tja a mostani id�t a napt�rnak.

        public void OnPost() //Ez a logika fog lefutni, ha r�ment�nk a ment�s gombra
        {
            Teendo ujTeendo = new Teendo();

            ujTeendo.Leiras = Cim;

            ujTeendo.Idopont = Datum;

            Tarhely.Teendok.Add(ujTeendo);
        }
    }
}
