using Business.Abstaract;
using Entities.Concerate;
using MennisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerate
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {


        }

        public bool CheckPerson(Person person)
        {
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);




                return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad: person.FirstName , Soyad:person.LastName, DogumYili:person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
            }




        }

        
        
    }
}
