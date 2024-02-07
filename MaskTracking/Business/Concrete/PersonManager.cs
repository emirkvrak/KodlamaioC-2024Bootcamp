using Business.Abstract;
using Entities.Concretes;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
    

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
                    person.NationalIdentity,
                    person.FirstName,
                    person.LastName,
                    person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
    }


}
