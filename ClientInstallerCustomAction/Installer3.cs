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

        protected override void OnBeforeInstall(IDictionary savedState)
        {

            base.OnBeforeInstall(savedState);
        }

    }

}
