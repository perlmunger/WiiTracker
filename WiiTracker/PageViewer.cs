using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WiiTracker
{
    public partial class PageViewer : Form
    {
        protected string content, filename, outputPath;

        public PageViewer()
        {
            InitializeComponent();
        }

        public PageViewer(string content, string filename)
        {
            InitializeComponent();
            this.content = content;
            this.filename = filename;
        }

        protected override void OnShown(EventArgs e)
        {
            LoadContent();
            base.OnShown(e);
        }
        public void LoadContent()
        {
            outputPath = Path.GetTempPath() + filename + ".html";
            StreamWriter writer = File.CreateText(outputPath);
            writer.Write(content);
            writer.Close();
            wbMain.Navigate(outputPath);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if( outputPath != null && outputPath.Length > 0 )
                if( File.Exists( outputPath ) )
                    File.Delete( outputPath );
            base.OnClosing(e);
        }

        
    }
}