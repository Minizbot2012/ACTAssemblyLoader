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
        private Label labelAssemblies;
        private OpenFileDialog addDLLFile;
        private CheckedListBox chklstAssemblies;
        private ListView lstLog;
        private Button btnRemoveAssembly;
        private Button btnAddAssembly;
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
            this.labelAssemblies = new System.Windows.Forms.Label();
            this.addDLLFile = new System.Windows.Forms.OpenFileDialog();
            this.chklstAssemblies = new System.Windows.Forms.CheckedListBox();
            this.lstLog = new System.Windows.Forms.ListView();
            this.btnRemoveAssembly = new System.Windows.Forms.Button();
            this.btnAddAssembly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAssemblies
            // 
            this.labelAssemblies.AutoSize = true;
            this.labelAssemblies.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAssemblies.Location = new System.Drawing.Point(0, 0);
            this.labelAssemblies.Name = "labelAssemblies";
            this.labelAssemblies.Size = new System.Drawing.Size(569, 13);
            this.labelAssemblies.TabIndex = 1;
            this.labelAssemblies.Text = "Place assemblies to load in text box below, one per line. Ensure this plugin load" +
    "s first, and restart ACT to apply changes.";
            this.labelAssemblies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addDLLFile
            // 
            this.addDLLFile.FileName = "openFileDialog1";
            this.addDLLFile.Filter = "DLL|*.dll";
            // 
            // chklstAssemblies
            // 
            this.chklstAssemblies.Dock = System.Windows.Forms.DockStyle.Left;
            this.chklstAssemblies.FormattingEnabled = true;
            this.chklstAssemblies.Location = new System.Drawing.Point(0, 13);
            this.chklstAssemblies.Name = "chklstAssemblies";
            this.chklstAssemblies.Size = new System.Drawing.Size(450, 287);
            this.chklstAssemblies.TabIndex = 2;
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstLog.Enabled = false;
            this.lstLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstLog.HideSelection = false;
            this.lstLog.Location = new System.Drawing.Point(450, 200);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(250, 100);
            this.lstLog.TabIndex = 3;
            this.lstLog.UseCompatibleStateImageBehavior = false;
            this.lstLog.View = System.Windows.Forms.View.List;
            // 
            // btnRemoveAssembly
            // 
            this.btnRemoveAssembly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveAssembly.Location = new System.Drawing.Point(450, 13);
            this.btnRemoveAssembly.Name = "btnRemoveAssembly";
            this.btnRemoveAssembly.Size = new System.Drawing.Size(250, 30);
            this.btnRemoveAssembly.TabIndex = 4;
            this.btnRemoveAssembly.Text = "Remove Selected Assembly";
            this.btnRemoveAssembly.UseVisualStyleBackColor = true;
            this.btnRemoveAssembly.Click += new System.EventHandler(this.btnRemoveAssembly_Click);
            // 
            // btnAddAssembly
            // 
            this.btnAddAssembly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAssembly.Location = new System.Drawing.Point(450, 43);
            this.btnAddAssembly.Name = "btnAddAssembly";
            this.btnAddAssembly.Size = new System.Drawing.Size(250, 30);
            this.btnAddAssembly.TabIndex = 5;
            this.btnAddAssembly.Text = "Add Assembly";
            this.btnAddAssembly.UseVisualStyleBackColor = true;
            this.btnAddAssembly.Click += new System.EventHandler(this.btnAddAssembly_Click);
            // 
            // ACTAssemblyLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnAddAssembly);
            this.Controls.Add(this.btnRemoveAssembly);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.chklstAssemblies);
            this.Controls.Add(this.labelAssemblies);
            this.Name = "ACTAssemblyLoader";
            this.Size = new System.Drawing.Size(700, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #endregion
    }
}
