using Dashboardscrum.Models;
using Dashboardscrum.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dashboardscrum.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly CrudRepository _crudRepository;
        private readonly UserRepository _userRepository;

        public IndexModel(CrudRepository crudRepository, UserRepository userRepository)
        {
            _crudRepository = crudRepository;
            _userRepository = userRepository;
        }
        public Team? Team { get; set; } 
        public void OnPost()
        { 
              
        }
    }
}
