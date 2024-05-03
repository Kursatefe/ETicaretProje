﻿using Entities;

namespace Service
{
    public interface IUserService
    {
        
        User Authenticate(string email, string password);

        
        User Register(RegisterViewModel model);

        
        void ForgotPassword(string email);
        bool ResetPassword(string email, string token, string newPassword);
    }
}