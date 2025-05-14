using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MyCustomAction
{
    [RunInstaller(true)]
    public partial class Installer3 : Installer
    {
        public Installer3()
        {
            InitializeComponent();
        }

        private bool isLocalDeployment = true;
        private string address = string.Empty;
        private string port = string.Empty;
        private string dbConnectionString = string.Empty;
        
        protected override void OnBeforeInstall(IDictionary savedState)
        {
            isLocalDeployment = AskForDeploymentMode();
            if(!isLocalDeployment)
                address = AskForHostName();
            port = AskForPort();
            dbConnectionString = AskForDbConnectionString();
            RegisterAsWindowsService();

            base.OnBeforeInstall(savedState);
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            UpdateIsDeploymentMode();
            UpdateAddress();
            UpdatePort();
            UpdateConnectionString();
            base.OnBeforeInstall(savedState);
        }


        private bool AskForDeploymentMode()
        {
            DialogResult result = MessageBox.Show(
            "Is application intended to be used in private inner network?",
            "Deployment Mode",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private string AskForDbConnectionString()
        {
            using (var dialog = new InputDialog("Enter mongoDB connection string"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string userInput = dialog.InputValue;
                    return userInput;
                }
                throw new Exception("Unexpected behaviour");
            }
        }
        private string AskForHostName()
        {
            using (var dialog = new InputDialog("Enter address which will be used by service to comunicate with agents:"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string userInput = dialog.InputValue;
                    return userInput;
                }
                throw new Exception("Unexpected behaviour");
            }
        }

        private string AskForPort()
        {
            using (var dialog = new InputDialog("Enter address port which will be used for comunicating with agents:"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string userInput = dialog.InputValue;
                    return userInput;
                }
                throw new Exception("Unexpected behaviour");
            }
        }

        private void UpdateIsDeploymentMode()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "SocketOptions", "LocalDeployment", isLocalDeployment.ToString());
            UpdateAppsettings(appSettingsAddress, jobj);
        }
        private void UpdateAddress()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "SocketOptions", "DnsAddress", address);
            UpdateAppsettings(appSettingsAddress, jobj);
        }
        private void UpdatePort()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "SocketOptions", "Port", port);
            UpdateAppsettings(appSettingsAddress, jobj);
        }

        private void UpdateConnectionString()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "MongoDbOptions", "ConnectionString", dbConnectionString);
            UpdateAppsettings(appSettingsAddress, jobj);
        }
        public static void RegisterAsWindowsService()
        {
            string currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string exePath = Path.Combine(currentPath, "Vordr.Client.WebApi.exe");

            var psi = new ProcessStartInfo
            {
                FileName = "sc.exe",
                Arguments = $"create VordrClient binPath= \"{exePath}\" start= auto",
                Verb = "runas", // run as admin
                UseShellExecute = true
            };

            Process.Start(psi);
        }
        private string GetAppsettingsAddress()
        {
            string currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);


            // Append appsettings.json
            string configPath = Path.Combine(currentPath, "appsettings.json");
            return configPath;
        }
        private JObject GetAppSettingsJObject(string configPath)
        {
                return JObject.Parse(File.ReadAllText(configPath));

        }

        private void UpdateAppsettings(string configPath, JObject jobject)
        {
            File.WriteAllText(configPath, jobject.ToString());

        }


        private void UpdateJObject(JObject jobject, string name, string value)
        {
            jobject[name] = value;
        }

        private void UpdateNestedJObject(JObject jobject, string name1, string name2, string value)
        {
            jobject[name1][name2] = value;
        }
    }

}
