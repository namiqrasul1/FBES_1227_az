﻿namespace TodoWebService.Providers
{
    public class UserInfo
    {
        public UserInfo(string id, string username)
        {
            Id = id;
            Username = username;
        }

        public string Id { get; set; }
        public string Username { get; set; }
    }
}
