using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using AltoHttp;
using System.IO;

namespace Pantomima
{
    public class NetInfo
    {
        public string UrlToDownload = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Quartz-152638.jpg/250px-Quartz-152638.jpg";
        public string DownloadDirectory = @"C:\Users\chers\source\repos\Pantomima\Pantomima\bin\Debug\MoviesInfoDownloaded\"; 
        public HttpDownloader httpDownloader;

        public void Search()
        {
            //search wiki and grab first result
            //if its a movie
            //then download the "https://commons.wikimedia.org/wiki/File:" until the first .jpg or .png
            //the first of them (I found 19 in a link but it was the first)
        }

        public HttpDownloader Download(string urlToDownload, string fullPathToDownload)
        {
            UrlToDownload = urlToDownload;
            DownloadDirectory = fullPathToDownload;
            httpDownloader = new HttpDownloader(urlToDownload, fullPathToDownload);
            //httpDownloader(txtUrl.Text, $"{Application.StartupPath)\\(Path.GetFileName(txtUrl.Text)}");
            httpDownloader.Start();
            return httpDownloader;
        }
    }
}
