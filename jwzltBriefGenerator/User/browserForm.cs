using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace jwzltBriefGenerator.User
{
    public partial class browserForm : Form
    {
        public string url = "www.baidu.com";
        public object obj = null;
        public string str = "";
        ChromiumWebBrowser chromeBrowser;
        public browserForm()
        {
            InitializeComponent();
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("--allow-file-access-from-files");
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
        }

        ~browserForm()
        {
            Cef.Shutdown();
        }

        //初始化浏览器并启动
        public void InitializeChromium()
        {
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(url);
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.DownloadHandler = new DownloadHandler();
            chromeBrowser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(FrameEndFunc);
        }

        private void FrameEndFunc(object sender, FrameLoadEndEventArgs e)
        {
            chromeBrowser.GetBrowser().MainFrame.ExecuteJavaScriptAsync("document.getElementById('info').value='" + str + "'; generate();");
        }

        private void browserForm_Load(object sender, EventArgs e)
        {
            InitializeChromium();
        }

        private void browserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            chromeBrowser.Dispose();
        }
    }

    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownloadFired?.Invoke(this, downloadItem);
            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);
        }
    }

}
