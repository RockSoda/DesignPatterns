﻿namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Request();
        }
    }
}