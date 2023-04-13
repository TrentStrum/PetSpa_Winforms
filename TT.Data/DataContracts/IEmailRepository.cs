using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IEmailRepository
    {
        DataTable EmailTable { get; }
        Email GetNewEmail();
        Email GetEmailById(int CustomerId);
        Email AddNewEmail(Email proposed);
        int UpdateEmail(Email proposed);
    }
}
