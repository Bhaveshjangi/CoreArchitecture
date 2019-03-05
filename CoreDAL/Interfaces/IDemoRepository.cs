using CoreModels.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDAL.Interfaces
{
    public interface IDemoRepository
    {
         TblDemo GetData();
    }
}
