using CoreDAL.Context;
using CoreDAL.Interfaces;
using CoreModels.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDAL.Repositories
{
    public class DemoRepository : IDemoRepository
    {
        private readonly DemoDBContext _demoDBContext;
        public DemoRepository(DemoDBContext demoDBContext)
        {
            _demoDBContext = demoDBContext;
        }
        public TblDemo GetData()
        {
            try
            {
                return new TblDemo();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
