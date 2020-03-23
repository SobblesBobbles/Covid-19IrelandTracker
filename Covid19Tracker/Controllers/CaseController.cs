using Covid19Tracker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Covid19Tracker.Vm;

namespace Covid19Tracker.Controllers
{
    public class CaseController : Controller
    {
        private CovidCaseManager _CovidCaseManager;
        public CaseController()
        {
            _CovidCaseManager = new CovidCaseManager();
        }
        // GET: Case
        public ActionResult Index()
        {
            try
            {
                var CurrentCovidCases = _CovidCaseManager.GetCovidCases();
                return View("CurrentCovidCases", CurrentCovidCases);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
    
        }

        public ActionResult Create ()
        {
            CreateCovidCaseOverview vm = new CreateCovidCaseOverview();
            AgeGroup Ages = new AgeGroup();
            GenderFactory Genders = new GenderFactory();

            vm.AllLocations = _CovidCaseManager.GetAllLocations();
            vm.AgeGroupRanges = Ages.GetAges();
            vm.GenderRange = Genders.GetGenders();
            return View("AddCovidCase", vm);
        }
        [HttpPost]
        public async Task<ActionResult> CreateCovidCase (CreateCovidCaseOverview vm)
        {
            try
            {
                var result = _CovidCaseManager.AddCovidCase(vm);

                return Index();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
   
        }
    }
}