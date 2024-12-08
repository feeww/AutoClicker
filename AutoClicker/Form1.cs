using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private Thread clickerThread;
        private bool isClicking = false;
        private Keys hotkey = Keys.F6;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        private const int HOTKEY_ID = 1;

        private void DisableButton(Button button1, Button button2)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
            button2.Enabled = true;
            button2.BackColor = Color.White;
        }

        public Form1()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)hotkey);
            DisableButton(btnStop, btnStart);
            UpdateHotkeyLabel();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                ToggleClicker();
            }
            base.WndProc(ref m);
        }
        private void StartClicker()
        {
            if (!isClicking)
            {
                isClicking = true;
                DisableButton(btnStart, btnStop);
                clickerThread = new Thread(ClickLoop) { IsBackground = true };
                clickerThread.Start();
            }
        }
        private void StopClicker()
        {
            if (isClicking)
            {
                isClicking = false;
                clickerThread?.Join();
                DisableButton(btnStop, btnStart);
            }
        }
        private void ToggleClicker()
        {
            if (isClicking)
            {
                StopClicker();
            }
            else
            {
                StartClicker();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartClicker();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopClicker();
        }

        private void ClickLoop()
        {
            uint clickType = rbLeftClick.Checked ? MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP : MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP;

            while (isClicking)
            {
                mouse_event(clickType, 0, 0, 0, 0);
                Thread.Sleep((int)numInterval.Value);
            }
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbTopMost.Checked;
        }

        private void btnBindHotkey_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press key to bind(Press OK than press Key).", "Hotkey Bind", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.KeyPreview = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.KeyPreview)
            {
                hotkey = keyData;
                UpdateHotkeyLabel();
                this.KeyPreview = false;

                UnregisterHotKey(this.Handle, HOTKEY_ID);
                RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)hotkey);

                MessageBox.Show($"New hotkey: {hotkey}", "Hotkey Bind", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateHotkeyLabel()
        {
            lblHotkey.Text = $"Hotkey: {hotkey}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }
    }
}
