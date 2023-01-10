using Dashboardscrum.Models;
using Dashboardscrum.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace Dashboardscrum.Pages.Docent
{
    public class CreateTeamModel : PageModel
    {
        private readonly CrudRepository _crudRepository;
        private readonly UserRepository _userRepository;

        public CreateTeamModel(CrudRepository crudRepository, UserRepository userRepository)
        {
            _crudRepository = crudRepository;
            _userRepository = userRepository;
        }

        [BindProperty] public Team Team { get; set; }

        public async Task<IActionResult> OnPostCreateTeam()
        {
            if (ModelState.IsValid)
            {
                Guid teamId = Guid.NewGuid();
                Team.TeamId = teamId;
                await _crudRepository.AddRow(Team);
            }
            return RedirectToPage("/Docent/TeamsOverzicht");
        }
    }
}
