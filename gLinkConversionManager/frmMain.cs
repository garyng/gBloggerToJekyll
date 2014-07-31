using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace gLinkConversionManager
{
	public partial class frmMain : Form
	{
		[DllImport("user32.dll")]
		static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

		[DllImport("user32.dll")]
		static extern IntPtr GetClipboardViewer();

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

		[DllImport("user32.dll", SetLastError = true)]
		static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		IntPtr _hwndNextViewer;
		const int WM_DESTROY = 0x0002;
		const int WM_CHANGECBCHAIN = 0x030D;
		const int WM_DRAWCLIPBOARD = 0x0308;

		Dictionary<string, DateTime?> _dPostInfoList = new Dictionary<string, DateTime?>();

		public frmMain()
		{
			InitializeComponent();
			_hwndNextViewer = SetClipboardViewer(this.Handle);
			loadFile();
		}


		protected override void WndProc(ref Message m)
		{
			switch(m.Msg)
			{
				case(WM_DESTROY):
					ChangeClipboardChain(this.Handle, _hwndNextViewer);
					break;
				case(WM_CHANGECBCHAIN):
					if (m.WParam == _hwndNextViewer)
						_hwndNextViewer = m.LParam;
					else if (_hwndNextViewer != IntPtr.Zero)
						SendMessage(_hwndNextViewer, m.Msg, m.WParam, m.LParam);
					break;
				case(WM_DRAWCLIPBOARD):
					clipboardChanged(Clipboard.GetText());
					SendMessage(_hwndNextViewer, m.Msg, m.WParam, m.LParam);
					break;
			}
			base.WndProc(ref m);
		}

		private void clipboardChanged(string content)
		{
			lbLog.Items.Insert(0, "Clipboard changed.");
			content.ToLower();
			if (isLink(content) && isLinkExist(content))
			{
				lbLog.Items.Insert(0, "Link detected.");
				lbLog.Items.Insert(0, convertLink(content));
				Clipboard.Clear();
				Clipboard.SetText(convertLink(content));
			}
			else
			{
				lbLog.Items.Insert(0, "Not a link.");
			}
		}

		private void loadFile()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "gbtk-data.json|gbtk-data.json";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				_dPostInfoList = deserializeDict(File.ReadAllText(ofd.FileName));
			}
			else
			{
				MessageBox.Show("No file selected.");
				Application.Exit();
			}
		}

		private Dictionary<string, DateTime?> deserializeDict(string content)
		{
			Dictionary<string, DateTime?> dict = new Dictionary<string, DateTime?>();
			try
			{
				MemoryStream ms = new MemoryStream();
				try
				{
					DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Dictionary<string, DateTime?>));
					ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
					dict = (Dictionary<string, DateTime?>)dcjs.ReadObject(ms);
				}
				finally
				{
					ms.Close();
					ms.Dispose();
				}
			}
			catch
			{
				MessageBox.Show("Not a valid gBloggerToJekyll json data file.");
				Application.Exit();
			}
			return dict;
		}

		private bool isLink(string str)
		{
			Uri res;
			if (Uri.TryCreate(str, UriKind.Absolute, out res))
				if (res.Scheme == Uri.UriSchemeHttp || res.Scheme == Uri.UriSchemeHttps)
					return true;
				else
					return false;
			else
				return false;
		}

		private bool isLinkExist(string link)
		{
			DateTime? res;
			return _dPostInfoList.TryGetValue(link, out res);
		}

		private string convertLink(string link)
		{
			link = link.ToLower();
			string postName = Path.GetFileNameWithoutExtension(new Uri(link).AbsolutePath).Trim().ToLower();
			DateTime? date = _dPostInfoList[link];
			string postDate = date.HasValue ? date.Value.ToString("yyyy-MM-dd").Trim() : DateTime.Now.ToString("yyyy-MM-dd").Trim();
			string postFilename = postDate + "-" + postName;
			
			return "{% post_url " + postFilename + " %}";
		}
	}
}
