﻿namespace BasicAuthentication.Security
{
    public interface IUserService
    {
        public bool IsUser(string email, string pass);
    }
}
