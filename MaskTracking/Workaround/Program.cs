using Business.Concrete;
using Entities.Concretes;

Person person = new()
{
    FirstName = "EMİR",
    LastName = "KIVRAK",
    DateOfBirthYear = 2003,
    NationalIdentity = 123
};

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);