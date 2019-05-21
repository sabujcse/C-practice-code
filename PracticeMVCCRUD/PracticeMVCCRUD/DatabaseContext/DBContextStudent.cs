using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace PracticeMVCCRUD.DatabaseContext
{
    public class DBContextStudent : BaseContext
    {
        DBset<DBContextStudent> student { get; set; }
    }
}