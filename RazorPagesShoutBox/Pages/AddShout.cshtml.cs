using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesShoutBox.Data;
using System;

namespace RazorPagesShoutBox.Pages
{
    public class AddShoutModel : PageModel
    {
        private readonly ShoutBoxContext _context;

        public AddShoutModel(ShoutBoxContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ShoutBoxItem Item { get; set; }

        public void OnGet()
        {
            if(Item == null)
            {
                Item = new ShoutBoxItem();
            }

            Item.Time = DateTime.Now;
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            Item.Id = 0;
            _context.ShoutBoxItems.Add(Item);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}