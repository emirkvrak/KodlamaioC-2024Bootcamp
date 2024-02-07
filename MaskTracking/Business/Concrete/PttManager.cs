using Business.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager:ISupplierService
{
    private IApplicantService _applicantService;
    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(Person person)
    {
        string message = _applicantService.CheckPerson(person) ? $"{person.FirstName} için maske verildi." : $"{person.FirstName} için maske verilemedi.";
        Console.WriteLine(message);
    }

}
