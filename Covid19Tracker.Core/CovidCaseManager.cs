﻿using Covid19Tracker.Core.Database;
using Covid19Tracker.Core.Models;
using Covid19Tracker.Vm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Core
{
   public class CovidCaseManager
    {
        private DatabaseContext _context;
        public CovidCaseManager()
        {
            _context = new DatabaseContext();
        }
        public CurrentCovidCasesOverview GetCovidCases()
        {
            try
            {
                var test = _context.CovidCase.ToList();
                CurrentCovidCasesOverview vm = new CurrentCovidCasesOverview();
                var CovidCases = _context.CovidCase.ToList().Select(s => new CovidCaseVm
                {
                    DateDiagnosed = s.DateDiagnosed,
                    AgeRange = s.AgeGroup,
                    Gender = s.Gender,
                    Town = s.Town.TownName,
                    County = s.Town.County.CountyName
                }).ToList();

                vm.CurrentCovidCases = CovidCases;
                vm.CovidCasesJson =JsonConvert.SerializeObject(vm.CurrentCovidCases);

                return vm;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool AddCovidCase (CreateCovidCaseOverview vm)
        {
            try
            {
                CovidCase CaseToadd = new CovidCase()
                {
                    AgeGroup = vm.AgeGroupPicked,
                    DateDiagnosed = vm.DateDiagnosed,
                    Gender = vm.GenderValue,
                    LocationId = vm.LocationId 
                };
                var AddedToCases = _context.CovidCase.Add(CaseToadd);
                _context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
 
        }

        public Dictionary<int, string> GetAllLocations ()
        {
            
            Dictionary<int, string> Locations = _context.Town.ToDictionary(k => k.TownId, v => v.TownName);

            return Locations;
        }
    }
}
