using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using OdeToFood.Models;

namespace OdeToFood
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "VysJKxMfnUwB2nVf6yYFGdT7n",
                consumerSecret: "HTNLuTBFHvCekfwtVyXiixzjLomSS9LMzXxizIgHkiLV1h3DWS");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "295732597291858",
                appSecret: "11688580199842665fdec727f69077d7");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
