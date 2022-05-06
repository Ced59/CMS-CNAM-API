using AutoMapper;
using Dto.LyraDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Queries.Interface;
using System;
using System.Net;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class LyraController : ControllerBase
    {
        readonly string _credentials = "Njk4NzYzNTc6dGVzdHBhc3N3b3JkX0RFTU9QUklWQVRFS0VZMjNHNDQ3NXpYWlEyVUE1eDdN";

        [HttpPost]
        [Route("createPayment")]
        public IActionResult Post(CreatePaymentData data)
        {
            if (string.IsNullOrEmpty(data.currency))
                return BadRequest();

            if (string.IsNullOrEmpty(data.orderId))
                return BadRequest();

            if (data.customer == null)
                return BadRequest();

            if (string.IsNullOrEmpty(data.customer.email))
                return BadRequest();

            try
            {
                using (var client = new WebClient())
                {
                    client.BaseAddress = "https://api.lyra.com";
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    client.Headers.Add(HttpRequestHeader.Authorization, string.Format("Basic {0}", _credentials));
                    string response = client.UploadString("/api-payment/V4/Charge/CreatePayment", "POST", JsonConvert.SerializeObject(data));
                    LyraFormTokenResponseDto dto = JsonConvert.DeserializeObject<LyraFormTokenResponseDto>(response);

                    if(dto.status == "ERROR")
                        return BadRequest();

                    return Ok(dto);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }


        public class CreatePaymentData
        {
            public int amount { get; set; }
            public string currency { get; set; }
            public string orderId { get; set; }
            public Customer customer { get; set; }
        }

        public class Customer
        {
            public string email { get; set; }
        }

    }
}
