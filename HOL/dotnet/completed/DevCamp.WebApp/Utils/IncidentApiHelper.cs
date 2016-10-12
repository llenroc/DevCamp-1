﻿using IncidentAPI;
using System;
using System.Configuration;

namespace DevCamp.WebApp.Utils
{
    public class IncidentApiHelper
    {
       public static IncidentAPIClient GetIncidentAPIClient()
        {
            var client = new IncidentAPIClient(new Uri(string.Format("https://{0}", Settings.INCIDENT_API_URL)));
            return client;
        }

    }
}
