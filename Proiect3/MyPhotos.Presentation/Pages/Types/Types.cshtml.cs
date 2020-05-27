using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotos.Presentation.Contracts;
using MyPhotos.Presentation.Models;

namespace MyPhotos.Presentation.Pages.Types
{
    public class TypesModel : PageModel
    {
        private readonly IService<Type> typeService;

        public TypesModel(IService<Type> typeService)
        {
            this.typeService = typeService;
        }

        public ICollection<Type> Types { get; set; }

        public async Task OnGetAsync()
        {
        }
    }
}