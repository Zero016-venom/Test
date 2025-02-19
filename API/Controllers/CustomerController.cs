﻿using Domain.DTO.Paging;
using Domain.DTO.Customer;
using Domain.Models;
using Domain.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _CustomerRepo;
        public CustomerController(ICustomerService CustomerRepo)
        {
            _CustomerRepo = CustomerRepo;
        }

        [HttpPost("CreateCustomer")]
        public async Task<int> CreateCustomer(CustomerCreateRequest request)
        {
            try
            {
                return await _CustomerRepo.AddCustomer(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //[HttpPost("GetListCustomer")]
        //public async Task<ResponseData<Customer>> GetListCustomer(CustomerRequest request)
        //{
        //    try
        //    {
        //        return await _CustomerRepo.GetCustomers(request);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        [HttpPost("GetCustomerById")]
        public async Task<Customer> GetCustomerById(Guid Id)
        {
            try
            {
                return await _CustomerRepo.GetCustomerById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateCustomer")]
        public async Task<int> UpdateCustomer(CustomerUpdateRequest request)
        {
            try
            {
                return await _CustomerRepo.UpdateCustomer(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteCustomer")]
        public async Task<int> DeleteCustomer(CustomerDeleteRequest request)
        {
            try
            {
                return await _CustomerRepo.DeleteCustomer(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
