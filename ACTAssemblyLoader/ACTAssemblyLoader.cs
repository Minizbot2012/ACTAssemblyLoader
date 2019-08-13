﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Advanced_Combat_Tracker;

namespace ACTAssemblyLoader
{
    public partial class ACTAssemblyLoader : IActPluginV1
    {
        Label lblStatus;    // The status label that appears in ACT's Plugin tab
        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\ACTAssemblyLoader.config.xml");
        SettingsSerializer xmlSettings;

        public ACTAssemblyLoader()
        {
            InitializeComponent();
        }

        public void DeInitPlugin()
        {
            SaveSettings();
            lblStatus.Text = "Plugin Exited";
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
            pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
            this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
            xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
            LoadSettings();

            lstLog.Items.Add("Plugin Started, loading assemblies...");
            foreach (var assembly in chklstAssemblies.CheckedItems)
            {
                var tempAssembly = assembly.ToString();
                lstLog.Items.Add("Loading assembly [" + tempAssembly + "]...");
                if (!File.Exists(tempAssembly))
                {
                    tempAssembly = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + Path.DirectorySeparatorChar + tempAssembly;
                }
                try
                {
                    Assembly a = Assembly.LoadFile(tempAssembly);
                    lstLog.Items.Add(" Loaded assembly, location = " + a.Location);
                }
                catch
                {
                    lstLog.Items.Add(" Error loading assembly");
                }
            }
        }


        void LoadSettings()
        {
            // Add any controls you want to save the state of
            xmlSettings.AddControlSetting(chklstAssemblies.Name, chklstAssemblies);
            
            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlTextReader xReader = new XmlTextReader(fs);

                try
                {
                    while (xReader.Read())
                    {
                        if (xReader.NodeType == XmlNodeType.Element)
                        {
                            if (xReader.LocalName == "SettingsSerializer")
                            {
                                xmlSettings.ImportFromXml(xReader);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error loading settings: " + ex.Message;
                }
                xReader.Close();
            }
        }
        void SaveSettings()
        {
            FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.Indentation = 1;
            xWriter.IndentChar = '\t';
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");    // <Config>
            xWriter.WriteStartElement("SettingsSerializer");    // <Config><SettingsSerializer>
            xmlSettings.ExportToXml(xWriter);   // Fill the SettingsSerializer XML
            xWriter.WriteEndElement();  // </SettingsSerializer>
            xWriter.WriteEndElement();  // </Config>
            xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
            xWriter.Flush();    // Flush the file buffer to disk
            xWriter.Close();
        }
        private void btnRemoveAssembly_Click(object sender, EventArgs e)
        {
            int sel = chklstAssemblies.SelectedIndex;
            chklstAssemblies.Items.Remove(sel);
        }

        private void btnAddAssembly_Click(object sender, EventArgs e)
        {
            if(addDLLFile.ShowDialog() == DialogResult.OK)
            {
                chklstAssemblies.Items.Add(addDLLFile.FileName, true);
            }
        }
    }
}
