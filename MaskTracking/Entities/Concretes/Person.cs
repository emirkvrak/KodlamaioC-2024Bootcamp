using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long NationalIdentity { get; set; }
    public short DateOfBirthYear { get; set; }

}
