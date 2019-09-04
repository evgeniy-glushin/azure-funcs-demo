using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Mail;
using ServiceStack.Auth;

namespace FunctionApp1
{
    public static class EmailLicenseFile
    {
        [FunctionName("EmailLicenseFile")]
        public static void Run(
            [BlobTrigger("licenses/{number}")] string content,
            [Table("orders", "orders", "{number}")] Order order,
            string number, 
            ILogger log)
        {
            //var email = Regex.Match("", @"^Email\:\ (.+)$", RegexOptions.Multiline).Groups[1].Value;
        }
    }
}
