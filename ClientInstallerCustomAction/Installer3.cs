using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Text;
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

        private WorkstationIdentifier serializedIdentifier;
        private string address = string.Empty;
        private string port = string.Empty;
        private string dbConnectionString = string.Empty;
        
        protected override void OnBeforeInstall(IDictionary savedState)
        {
            var identifier = AskForIdentifier();
            var decodedBytes = Convert.FromBase64String(identifier);
            var jsonString = Encoding.UTF8.GetString(decodedBytes);

            serializedIdentifier = jsonString.JsonDeserialize<WorkstationIdentifier>();

            base.OnBeforeInstall(savedState);
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            UpdatePort();
            UpdateClientId();
            UpdateAddress();
            base.OnBeforeInstall(savedState);
        }


        private string AskForIdentifier()
        {
            using (var dialog = new InputDialog("Enter Vordr client identifier:"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string userInput = dialog.InputValue;
                    return userInput;
                }
                throw new Exception("Unexpected behaviour");
            }
        }

       

        private void UpdateAddress()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "SocketOptions", "LocalDeployment", serializedIdentifier.Address);
            UpdateAppsettings(appSettingsAddress, jobj);
        }
        private void UpdatePort()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "SocketOptions", "LocalDeployment", serializedIdentifier.Port.ToString());
            UpdateAppsettings(appSettingsAddress, jobj);
        }
        
        private void UpdateClientId()
        {
            var appSettingsAddress = GetAppsettingsAddress();
            var jobj = GetAppSettingsJObject(appSettingsAddress);
            UpdateNestedJObject(jobj, "SocketOptions", "LocalDeployment", serializedIdentifier.ClientId);
            UpdateAppsettings(appSettingsAddress, jobj);
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
