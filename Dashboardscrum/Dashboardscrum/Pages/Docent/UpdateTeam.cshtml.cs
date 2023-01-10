using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dashboardscrum.Repositories;
using System.Runtime.InteropServices;
using Dashboardscrum.Models;
using System.Diagnostics.Contracts;

namespace Dashboardscrum.Pages.Docent
{
    public class UpdateTeamModel : PageModel
    {
        public readonly Guid TeamId;
        private readonly CrudRepository _crudRepository;
        private readonly UserRepository _userRepository;

        public UpdateTeamModel(IHttpContextAccessor httpContext, CrudRepository crudRepository, UserRepository userRepository)
        {
            GeneralRepository.parseId(httpContext, out TeamId);
            _crudRepository = crudRepository;
            _userRepository = userRepository;
            _applicationUsers = crudRepository.ReadAllRows<ApplicationUser>().Result;
        }

        [BindProperty] public ApplicationUser? ApplicationUser { get; set; }
        [BindProperty] public Team? Team { get; set; }

        public List<ApplicationUser>? _applicationUsers { get; set; }
        public List<Team> _teams { get; set; }


        public async Task<IActionResult> OnPostUpdateTeam()
        {
            if (ApplicationUser != null)
            {
                await _crudRepository.UpdateRow(ApplicationUser);
            }
            return RedirectToPage("/Docent/UpdateTeam" + TeamId);
        }
        public async Task<IActionResult> OnPostDeleteTeamlid()
        {
            if (_applicationUsers != null)
            {
                
                //TODO: TeamId van ApplicationUser verwijderen.
            }

            return RedirectToPage("/Docent/UpdateTeam" + TeamId);

        }
    }
}
