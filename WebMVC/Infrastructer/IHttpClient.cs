﻿namespace WebMVC.Infrastructer
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri,
            string authorizationToken = null, string authorizationMethod = "Bearer");
    }
}
