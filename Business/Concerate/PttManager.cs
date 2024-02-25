using Business.Abstaract;
using Entities.Concerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerate
{
    public class PttManager: ISupplierManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService  applicantService)
        {
            _applicantService = applicantService;


        }

        public void GiveMask(Person person )
        {
            if (_applicantService.CheckPerson(Person)) 
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");

            }

        }


    }
}
