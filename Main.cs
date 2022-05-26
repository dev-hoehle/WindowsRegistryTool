using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace RegistryTool
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public static void reg_local(string path, string valuename, int value)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true);
            key.SetValue(valuename, value, RegistryValueKind.DWord);
            key.Close();
        }
        public static void reg_currentuser(string path, string valuename, int value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            key.SetValue(valuename, value, RegistryValueKind.DWord);
            key.Close();
        }
        public static void reg_currentuserstring(string path, string valuename, string value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            key.SetValue(valuename, value, RegistryValueKind.String);
            key.Close();
        }

        private void disablelastun_Click(object sender, EventArgs e)
        {
            reg_local(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "dontdisplaylastusername", 1);
            MessageBox.Show("The user names at login are no longer displayed.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            reg_local(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "dontdisplaylastusername", 0);
            MessageBox.Show("The user names at login are now displayed again.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            reg_currentuserstring(@"Control Panel\Desktop", "MenuShowDelay", "50");
            MessageBox.Show("The menu delay was set to 50 ms.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            reg_currentuserstring(@"Control Panel\Desktop", "MenuShowDelay", "400");
            MessageBox.Show("The menu delay was set to 400 ms.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", 1);
            DialogResult dialogResult = MessageBox.Show("Activated. Your pc must be restarted for " + Environment.NewLine + "the changes to take effect. " + Environment.NewLine + "Do you want to restart now?", "RegistryTool", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("ShutDown", "/r");
            }
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", 0);
            DialogResult dialogResult = MessageBox.Show("Activated. Your pc must be restarted for " + Environment.NewLine + "the changes to take effect. " + Environment.NewLine + "Do you want to restart now?", "RegistryTool", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("ShutDown", "/r");
            }
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {
            reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking", 0);
            MessageBox.Show("Allowed Shaking to minimize", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {
            reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking", 1);
            MessageBox.Show("Disallowed Shaking to minimize", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void siticoneRoundedButton10_Click(object sender, EventArgs e)
        {

            reg_local(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutDown", 1);
            MessageBox.Show("ClearPageFileAtShutDown is now enabled", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton11_Click(object sender, EventArgs e)
        {
            reg_local(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutDown", 0);
            MessageBox.Show("ClearPageFileAtShutDown is now disabled", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton8_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", true);
            key.CreateSubKey(@"MTCUVC");
            key.Close();

            reg_local(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", 0);
            MessageBox.Show("The old volume control is now enabled.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton9_Click(object sender, EventArgs e)
        {

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\MTCUVC", true);
            if (key == null)
            {
                MessageBox.Show("The old volume control is already disabled.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reg_local(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", 1);
                MessageBox.Show("The old volume control is now disabled.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            key.Close();
        }

        private void siticoneRoundedButton13_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft", true);
            key.CreateSubKey(@"Explorer");
            key.Close();
            reg_local(@"SOFTWARE\Policies\Microsoft", "Disable Search Box Suggestions", 1);
            reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", 0);
            reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", 0);
            MessageBox.Show("The bing search resluts are now disabled.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneRoundedButton12_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Explorer", true);
            if (key != null)
            {
                reg_local(@"SOFTWARE\Policies\Microsoft", "Disable Search Box Suggestions", 0);
                reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", 1);
                reg_currentuser(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", 1);
                MessageBox.Show("The bing search resluts are now enabled again.", "RegistryTool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            key.Close();
        }
    }

}