﻿namespace dotnet_rpg.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<ServiceResponse<string>> Login(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
