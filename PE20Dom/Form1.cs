using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);


            // if you want to use example.html from a local folder (saved in c:\temp for example):
            this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

        }
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElement = webBrowser.Document.GetElementsByTagName("h1")[0];
            if (htmlElement != null )
            {
                htmlElement.InnerText = "My UFO Page"; 
            }
            htmlElement = webBrowser.Document.GetElementsByTagName("h2")[0];
            if (htmlElement != null)
            {
                htmlElement.InnerText = "My UFO Info";
            }
            htmlElement = webBrowser.Document.GetElementsByTagName("h2")[1];
            if (htmlElement != null)
            {
                htmlElement.InnerText = "My UFO Pictures";
            }
            htmlElement = webBrowser.Document.GetElementsByTagName("h2")[2];
            if (htmlElement != null)
            {
                htmlElement.InnerText = "";
            }
            htmlElement = webBrowser.Document.Body; 
            if (htmlElement != null )
            {
                htmlElement.Style = "fonr-family: sans-serif";
                htmlElement.Style += "color: #FF0000"; 
            }
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[1]; 
            if(htmlElement != null )
            {
                htmlElement.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org/'>http://www.nuforc.org/</a>";
                htmlElement.Style = "color: #00FF00";
                htmlElement.Style += "font-weight: bold";
                htmlElement.Style += "font-size: 2em";
                htmlElement.Style += "text-transform: uppercase";
                htmlElement.Style += "text-shadow: 3px2px #A44";
            }
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[1]; 
            if (htmlElement != null) 
            {
                htmlElement.InnerHtml = "";
            }
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[2]; 
            if(htmlElement != null)
            {
                htmlElement = webBrowser.Document.CreateElement("img");
                htmlElement.SetAttribute("src", "file:///C:/Users/Laila%20Porter/OneDrive%20-%20rit.edu/Desktop/IGME%20201/myIGME-201/PE20Dom/ufo.webp");
            }
            htmlElement = webBrowser.Document.CreateElement("footer"); 
            htmlElement.InnerHtml = "&copy 2023 Laila Porter" 
        }


    }
}
