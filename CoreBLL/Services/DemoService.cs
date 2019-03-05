using CoreBLL.Interfaces;
using CoreDAL.Context;
using CoreDAL.Interfaces;
using CoreModels.DataModels;
using CoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CoreBLL.Services
{
    public class DemoService : IDemoService
    {
        private readonly IDemoRepository _IDemoRepository;
        public DemoService(IDemoRepository idemoRepository)
        {
            _IDemoRepository = idemoRepository;
        }

        public ServiceResult GetData()
        {
            try
            {
                return new ServiceResult {
                    Message = "Test Message",
                    ResultData = _IDemoRepository.GetData(),
                    Status=true,
                    StatusCode= Convert.ToInt32(HttpStatusCode.OK)
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
