using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QReader.Utils
{
    public class ClipBoardMonitor : NativeWindow
    {

        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30d;

        [DllImport("user32.dll")]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll")]
        private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public event EventHandler NewImage;

        private IntPtr NextClipBoardViewerHandle;

        public ClipBoardMonitor()
        {
            this.CreateHandle(new CreateParams());
            this.NextClipBoardViewerHandle = SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if (Clipboard.ContainsImage())
                    {
                        NewImage?.Invoke(null, EventArgs.Empty);
                    }
                    SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);

                    break;
                case WM_CHANGECBCHAIN:
                    if (m.WParam == NextClipBoardViewerHandle)
                        NextClipBoardViewerHandle = m.LParam;
                    else
                        SendMessage(NextClipBoardViewerHandle, m.Msg, m.WParam,
                                    m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }

            base.WndProc(ref m);
        }

    }
}
