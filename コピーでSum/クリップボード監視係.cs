using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace コピーでGoKei
{
    public class TextEventArgs : EventArgs
    {
        private string text;

        public string Text
        {
            get { return this.text; }
        }

        public TextEventArgs(string str)
        {
            this.text = str;
        }
    }

    public delegate void TextEventHandler(object sender, TextEventArgs ev);

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    class クリップボード監視係 : NativeWindow
    {
        [DllImport("user32")]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("user32")]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32")]
        public extern static int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        const int WM_DRAWCLIPBOARD = 0x0308;
        const int WM_CHANGECBCHAIN = 0x030D;
        IntPtr nextHandle;

        Form parent;
        public event EventHandler ClipboardChanged;

        public クリップボード監視係(Form f)
        {
            f.HandleCreated += OnHandleCreated;
            f.HandleDestroyed += OnHandleDestroyed;
            this.parent = f;
        }

        internal void OnHandleCreated(object sender, EventArgs e)
        {
            AssignHandle(((Form)sender).Handle);
            // ビューアを登録
            nextHandle = SetClipboardViewer(this.Handle);
        }

        internal void OnHandleDestroyed(object sender, EventArgs e)
        {
            // ビューアを解除
            bool sts = ChangeClipboardChain(this.Handle, nextHandle);
            ReleaseHandle();
        }

        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {

                case WM_DRAWCLIPBOARD:
                    if (ClipboardChanged != null) ClipboardChanged(this, new EventArgs());
                    if ((int)nextHandle != 0) SendMessage(nextHandle, msg.Msg, msg.WParam, msg.LParam);
                    break;

                // クリップボード・ビューア・チェーンが更新された
                case WM_CHANGECBCHAIN:
                    if (msg.WParam == nextHandle) nextHandle = (IntPtr)msg.LParam;
                    else if ((int)nextHandle != 0) SendMessage(nextHandle, msg.Msg, msg.WParam, msg.LParam);
                    break;
            }
            base.WndProc(ref msg);
        }
    }
}