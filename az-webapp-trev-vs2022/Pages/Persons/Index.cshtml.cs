using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using az_webapp_trev_vs2022.Data;

namespace az_webapp_trev_vs2022.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly az_webapp_trev_vs2022.Data.AppDbContext _context;

        public IndexModel(az_webapp_trev_vs2022.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
