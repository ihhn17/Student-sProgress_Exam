﻿using Microsoft.AspNetCore.SignalR;

namespace StudentsProgress.Web.Infrastructure
{
    public class CustomUserIdProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
        {
            return connection.User?.Identity.Name;
        }
    }
}
