﻿using AutoMapper;
using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using ContactManagementSystem26_10_17.Services.Accounts;
using ContactManagementSystem26_10_17.Services.RegistrationNos;
using ContactManagementSystem26_10_17.Services.RegistrationNos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactManagementSystem26_10_17.Controllers
{
    [EnableCorsAttribute("*", "*", "*", SupportsCredentials = true)]
    public class RegistrationController : ApiController
    {
        // GET api/values

        //[HttpPost]
        //public bool RegisterUser(User data)
        //{
        //    var dbcontext = new RegisterOwnersContext();
        //    dbcontext.Users.Add(data);
        //    dbcontext.SaveChanges();
        //    return true;
        //}
        [HttpPost]
        public RegistrationUserData RegisterUser(User data)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                dbcontext.Users.Add(data);
                dbcontext.SaveChanges();

                string url = " <a href=http://registerownertest.apphb.com/Home/EmailVerification?Id=" + data.Id + ">" + "Verify Email" + "</a>";
                SendEmail(data.Email, url);

                return new RegistrationUserData
                {
                    IsUserRegisterd = true,
                    Message = "User Is Registered SuccessFully",
                    ErrorException = null
                };
            }
            catch (Exception ex)
            {
                return new RegistrationUserData
                {
                    IsUserRegisterd = false,
                    Message = "Internal Server Error",
                    ErrorException = ex
                };

            }
        }
        [HttpPost]
        public dynamic SignIn(User input)
        {
            var dbcontext = new RegisterOwnersContext();
            var userEntity = dbcontext.Users.FirstOrDefault(e => e.Email == input.Email && e.Password == input.Password && e.IsEmailVerified == true);
            if (userEntity == null)
                return new
                {
                    IsSignedIn = false,
                    //Message = "User Does Not Exist",
                    Message= dbcontext.Users.FirstOrDefault(e => e.Email == input.Email && e.Password == input.Password) !=null? "Verify Email": "User Does Not Exist"
                };
            return new
            {
                IsSignedIn = true,
                Message = "SuccessFully SignedIn",
                LogInResponse = Mapper.Map<User, UserDto>(userEntity)
            };
            // return Mapper.Map<User, UserDto>(userEntity);
        }
        [HttpPost]
        public dynamic GetAutoRegistrationNo(GetRegistrationNoInput input)
        {
            return new RegistrationNoAppService().GetAutoRegistrationNo(input);
        }

        [HttpPost]
        public dynamic GetMultipleAutoRegistrationNo(GetMultipleRegistrationNoInput [] input)
        {
            return new RegistrationNoAppService().GetMultipleAutoRegistrationNo(input);
        }
        [HttpPost]
        public dynamic GetManualRegistrationNumber(GetManualRegistrationNoInput input)
        {
            return new RegistrationNoAppService().GetManualRegistrationNumber(input);
        }
        [HttpPost]
        public dynamic GetOwnedRegistrationNumbers(GetOwnedRegistrationNumbersInput input)
        {
            return new RegistrationNoAppService().GetOwnedRegistrationNumbers(input);
        }

        [HttpPost]
        public dynamic UpdateUser(UserDto input)
        {
            return new AccountAppService().UpdateUser(input);
        }

        [HttpPost]
        public dynamic TransferRegistrationNumberToNewUser(TransferRegistrationNumberToNewUserInput input)
        {
            return new RegistrationNoAppService().TransferRegistrationNumberToNewUser(input);
        }


        // Sending Email Code

        public void SendEmail(string email, string body)
        {
            var SenderEmail = new MailAddress("hammadhassan4424@gmail.com");
            var ReceiverEmail = new MailAddress(email);
            var password = "xploiter1702211fc";
            var subject = "Email Verification Register Owner";

            var Body = body;
            var smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(SenderEmail.Address, password)
            };

            var mess = new MailMessage(SenderEmail, ReceiverEmail);
            mess.Body = Body;
            mess.Subject = subject;
            smtp.Send(mess);

        }

        [HttpGet]
        public bool VerifyEmail(int id)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                var user = dbcontext.Users.Single(e => e.IsEmailVerified == null && e.Id == id);
                user.IsEmailVerified = true;
                dbcontext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }


        [HttpPost]
        public dynamic ForgotPassword(ForgotPasswordInput input)
        {
            // ForGot Pass
            try
            {
                var dbcontext = new RegisterOwnersContext();
                var user = dbcontext.Users.Single(e => e.Email == input.Email);
                string url = " <a href=http://registerownertest.apphb.com/Home/ForgotPassword?Id=" + user.Id + ">" + "Forgot Password" + "</a>";
                SendEmail(input.Email, url);
                return new
                {

                    emailSent = true
                };

            }
            catch (Exception ex)
            {
                return new
                {

                    emailSent = false
                };


            }


        }


        public dynamic ChangePassword(User input)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                var user = dbcontext.Users.Single(e => e.IsEmailVerified == true && e.Id == input.Id);
                user.Password = input.Password;
                dbcontext.SaveChanges();

                return new
                {
                    passwordChanged = true
                };
            }
            catch
            {
                return new
                {
                    passwordChanged = false
                };
            }

        }


    }

    public class RegistrationUserData
    {
        public bool IsUserRegisterd { get; set; }
        public string Message { get; set; }
        public Exception ErrorException { get; set; }

    }

    public class UserDto
    {

        public int Id { get; set; }
        public string DeviceId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string Place { get; set; }
        public string Country { get; set; }
        public string MobileNo { get; set; }


    }

    public class ForgotPasswordInput
    {
        public string Email { get; set; }
    }
}
