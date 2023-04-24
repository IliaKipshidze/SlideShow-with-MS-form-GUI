using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace slideShow
{
    internal class class1
    {
        private static HashSet<string> imageExtensions =
            new HashSet<string> { "jpg", "jpeg", "gif", "png", ".bmp" };

        // ვაერთებთ remote დირექტორიის მისამართსა და ფაილის სახელს
        private static string JoinUrl(string httpDirectory, string httpFile)
        {
            // იქნება და პირდაპირ ლინკია :DD
            if (httpFile.StartsWith("http://") || httpFile.StartsWith("https://")) return httpFile;

            // ვაფორმატებთ მისამართსა და ფაილის სახელს
            httpDirectory = httpDirectory.Replace("\\", "/");
            httpFile = httpFile.Replace("\\", "/");
            if (httpDirectory.Last() != '/') httpDirectory.Append('/');
            if (httpFile.First() == '/') httpFile = httpFile.Substring(1);

            // საბოლოოდ ვაბრუნებთ შეერთებულ მისამართს
            return httpDirectory + httpFile;
        }

        // დირექტორიიდან ვიწერთ ყველა სურათს ლოკალურად და ვაბრუნებთ მათ ლოკალურ მისამართებს
        public static List<string> DownloadAllImages(string httpDirectory)
        {
            // ვიწერთ და ვკითხულობთ html დოკუმენტს მისამართიდან
            string rawHtml = new WebClient().DownloadString(httpDirectory);
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(rawHtml);

            // ვინახავთ მიღებული სურათების მისამართსა და გაფართოებას
            List<(string, string)> imageUrls = new List<(string, string)>();

            // გადმოწერილი html დოკუმენტიდან ვფილტრავთ ლინკებს
            var fileUrls = document.DocumentNode.Descendants("img").Select(n => n.Attributes["src"].Value).ToList();

            // მიღებული სიიდან ვარჩევთ მხოლოდ სურათის ტიპის ფაილებს
            foreach (var url in fileUrls)
            {
                var parts = url.Split('.');
                if (parts.Length < 2) continue;
                string extension = parts[parts.Length - 1].ToLower();
                if (imageExtensions.Contains(extension))
                    imageUrls.Add((JoinUrl(httpDirectory, url), extension));
            }

            // ვქმნით დროებით დირექტორიას გადმოწერილი ფაილების შესანახად
            string downloadDirectory = Path.GetTempPath() + Guid.NewGuid().ToString() + "/";
            Directory.CreateDirectory(downloadDirectory);

            // ვიმახსოვრებთ გადმოწერილი ფაილების მისამართს
            List<string> downloadedFiles = new List<string>();

            // სათითაოდ ვიწერთ ფაილებს
            foreach (var url in imageUrls)
            {
                string localName = downloadDirectory + Guid.NewGuid().ToString() + "." + url.Item2;
                try
                {
                    (new WebClient()).DownloadFile(url.Item1, localName);
                    downloadedFiles.Add(localName);
                }
                catch (Exception) { }
            }

            return downloadedFiles;
        }

        /*static void Main(string[] args)
        {
            // ვიძახებთ და ვბეჭდავთ გადმოწერილი სურათების მისამართებს
            //Console.WriteLine(String.Join("\n", DownloadAllImages("http://localhost:8080/web-project/")));
            Console.WriteLine(String.Join("\n", DownloadAllImages("https://intermedia.ge/%E1%83%A1%E1%83%A2%E1%83%90%E1%83%A2%E1%83%98%E1%83%90/71847-%E1%83%9E%E1%83%98%E1%83%A0%E1%83%95%E1%83%94%E1%83%9A%E1%83%98-%E1%83%A4%E1%83%9D%E1%83%A2%E1%83%9D%E1%83%94%E1%83%91%E1%83%98-%E1%83%9B%E1%83%A1%E1%83%9D%E1%83%A4%E1%83%9A%E1%83%98%E1%83%9D%E1%83%A8%E1%83%98-%E1%83%A1%E1%83%90%E1%83%98%E1%83%93%E1%83%90%E1%83%9C-%E1%83%98%E1%83%AC%E1%83%A7%E1%83%94%E1%83%91%E1%83%90-%E1%83%A4%E1%83%9D%E1%83%A2%E1%83%9D%E1%83%92%E1%83%A0%E1%83%90%E1%83%A4%E1%83%98%E1%83%98%E1%83%A1-%E1%83%98%E1%83%A1%E1%83%A2%E1%83%9D%E1%83%A0%E1%83%98%E1%83%90/82/")));
        }*/

    }
}
