using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTAssemblyLoader
{
    public partial class ACTAssemblyLoader : UserControl
    {
        private OpenFileDialog addDLLFile;
        private TabControl tabControl;
        private TabPage Tabs;
        private Button btnRemoveAssembly;
        private Button btnAddAssembly;
        private CheckedListBox chklstAssemblies;
        private TabPage tabPage2;
        private ListView lstLog;
        private Label label1;
        #region Designer Created Code (Avoid editing)
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACTAssemblyLoader));
            this.addDLLFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Tabs = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveAssembly = new System.Windows.Forms.Button();
            this.btnAddAssembly = new System.Windows.Forms.Button();
            this.chklstAssemblies = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstLog = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDLLFile
            // 
            this.addDLLFile.FileName = "openFileDialog1";
            this.addDLLFile.Filter = "DLL|*.dll";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Tabs);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(700, 300);
            this.tabControl.TabIndex = 6;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.label1);
            this.Tabs.Controls.Add(this.btnRemoveAssembly);
            this.Tabs.Controls.Add(this.btnAddAssembly);
            this.Tabs.Controls.Add(this.chklstAssemblies);
            this.Tabs.Location = new System.Drawing.Point(4, 22);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs.Size = new System.Drawing.Size(692, 274);
            this.Tabs.TabIndex = 0;
            this.Tabs.Text = "Settings";
            this.Tabs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(453, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 222);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // btnRemoveAssembly
            // 
            this.btnRemoveAssembly.AutoSize = true;
            this.btnRemoveAssembly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveAssembly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveAssembly.Location = new System.Drawing.Point(453, 26);
            this.btnRemoveAssembly.Name = "btnRemoveAssembly";
            this.btnRemoveAssembly.Size = new System.Drawing.Size(236, 23);
            this.btnRemoveAssembly.TabIndex = 7;
            this.btnRemoveAssembly.Text = "Remove Selected Assembly";
            this.btnRemoveAssembly.UseMnemonic = false;
            this.btnRemoveAssembly.UseVisualStyleBackColor = true;
            this.btnRemoveAssembly.Click += new System.EventHandler(this.btnRemoveAssembly_Click);
            // 
            // btnAddAssembly
            // 
            this.btnAddAssembly.AutoSize = true;
            this.btnAddAssembly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAssembly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAssembly.Location = new System.Drawing.Point(453, 3);
            this.btnAddAssembly.Name = "btnAddAssembly";
            this.btnAddAssembly.Size = new System.Drawing.Size(236, 23);
            this.btnAddAssembly.TabIndex = 6;
            this.btnAddAssembly.Text = "Add Assembly";
            this.btnAddAssembly.UseMnemonic = false;
            this.btnAddAssembly.UseVisualStyleBackColor = true;
            this.btnAddAssembly.Click += new System.EventHandler(this.btnAddAssembly_Click);
            // 
            // chklstAssemblies
            // 
            this.chklstAssemblies.Dock = System.Windows.Forms.DockStyle.Left;
            this.chklstAssemblies.FormattingEnabled = true;
            this.chklstAssemblies.Location = new System.Drawing.Point(3, 3);
            this.chklstAssemblies.Name = "chklstAssemblies";
            this.chklstAssemblies.Size = new System.Drawing.Size(450, 268);
            this.chklstAssemblies.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.Enabled = false;
            this.lstLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstLog.HideSelection = false;
            this.lstLog.Location = new System.Drawing.Point(3, 3);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(686, 268);
            this.lstLog.TabIndex = 4;
            this.lstLog.UseCompatibleStateImageBehavior = false;
            this.lstLog.View = System.Windows.Forms.View.List;
            // 
            // ACTAssemblyLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tabControl);
            this.Name = "ACTAssemblyLoader";
            this.Size = new System.Drawing.Size(700, 300);
            this.tabControl.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.Tabs.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #endregion
    }
}
