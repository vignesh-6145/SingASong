﻿using SingASong.Models;
using System.Net;

namespace SingASong.Clients
{
    public class APIClient
    {
        HttpClient client;

        public APIClient(string BaseAddress)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress);

        }
        public HttpStatusCode MakePutCall(string url, Track obj)
        {
            HttpResponseMessage response = client.PutAsJsonAsync(url, obj).GetAwaiter().GetResult();
            Console.WriteLine(response.Content);
            return response.StatusCode;
        }
        //public HttpStatusCode MakePostCall(string url, Payment obj)
        //{
        //    HttpResponseMessage response = client.PostAsJsonAsync(url, obj).GetAwaiter().GetResult();
        //    Console.WriteLine(response.StatusCode);
        //    return response.StatusCode;
        //}
        public HttpStatusCode MakePostCall(string url, Track obj)
        {
            HttpResponseMessage response = client.PostAsJsonAsync(url, obj).GetAwaiter().GetResult();
            Console.WriteLine(response.StatusCode);
            return response.StatusCode;
        }
        public HttpResponseMessage MakePostCall(string url, User obj)
        {
            HttpResponseMessage response = client.PostAsJsonAsync(url, obj).GetAwaiter().GetResult();
            Console.WriteLine(response.StatusCode);
            return response;
        }
        public string MakePostCall(string url)
        {
            HttpResponseMessage response = client.PostAsync(url, null).GetAwaiter().GetResult();
            Console.WriteLine(response.StatusCode);
            return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }
        public string MakeGetAPICall(string url)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var resposneStr = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    //need to send along with the response code
                    return resposneStr;
                }
                else
                {
                    Console.WriteLine("Some with went wrong");
                }
                return "<null>";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Couldn't Make a call to {client.BaseAddress + url}");
                Console.WriteLine(ex.Message);
            }

            return "<null>";
        }

        public HttpStatusCode MakeDeleteCall(string url)
        {
            HttpResponseMessage response = client.DeleteAsync(url).GetAwaiter().GetResult();
            return response.StatusCode;

        }
    }
}
