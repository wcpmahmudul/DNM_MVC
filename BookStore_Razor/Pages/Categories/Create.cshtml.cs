using BookStore_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore_Razor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
