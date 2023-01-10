using Dashboardscrum.Models;
using Dashboardscrum.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace Dashboardscrum.Pages.Docent
{
    public class TeamsOverzichtModel : PageModel
    {
        private readonly CrudRepository _crudRepository;
        private readonly UserRepository _userRepository;

        public TeamsOverzichtModel  (CrudRepository crudRepository, UserRepository userRepository)
        {
            _crudRepository = crudRepository;
            _userRepository = userRepository;
            _Team = crudRepository.ReadAllRows<Team>().Result;
        }

        [BindProperty] public Team? Team { get; set; }

        public List<Team> _Team { get; set; }

        public async Task<IActionResult> OnPostDeletePoint()
        {
            if (_Team != null)
            {
                await _crudRepository.RemoveRow(_Team.First(x => Team != null && x.TeamId == Team.TeamId));
                _Team.RemoveAll(x => Team != null && x.TeamId == Team.TeamId);
            }

            return RedirectToPage("/Docent/TeamOverzicht");

        }

        public async Task<IActionResult> OnPostUpdateTeam()
        {
            return Redirect("/Docent/UpdateTeam?TeamId=" + Team.TeamId);
        }
    }
}
