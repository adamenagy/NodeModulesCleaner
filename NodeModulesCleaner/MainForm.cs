using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using System.Xml.XPath;

namespace NodeModulesCleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                folderPath.Text = fbd.SelectedPath;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (folderPath.Text != "")
            {
                processStatus.Text = "Working...";
                string[] fileNames = filesToKeep.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                checkFolder(folderPath.Text, fileNames, false);
                processStatus.Text = "Done";
            }    
        }

        private bool checkFolder(string folderPath, string[] fileNames, bool onlyValidate)
        {
            bool keepFolder = false;
            var files = Directory.EnumerateFiles(folderPath);
            foreach (var file in files)
            {
                if (onlyValidate)
                {
                    if (file.EndsWith("package.json"))
                    {
                        checkPackage(file);
                    }
                }
                else
                {
                    bool keepFile = false;
                    foreach (var fileName in fileNames)
                    {
                        if (file.EndsWith(fileName))
                        {
                            keepFile = true;
                            keepFolder = true;

                            // Don't add it to package.json files, only to JavaScript files
                            if (file.EndsWith(".js"))
                                addCopyright(file);

                            break;
                        }
                    }

                    if (!keepFile)
                    {
                        File.Delete(file);
                    }
                }
           
            }

            var folders = Directory.EnumerateDirectories(folderPath);
            foreach (var folder in folders)
            {
                if (checkFolder(folder, fileNames, onlyValidate))
                    keepFolder = true;
            }

            if (!keepFolder && !onlyValidate)
                Directory.Delete(folderPath);

            return keepFolder;
        }

        /// <summary>
        /// Detects the byte order mark of a file and returns
        /// an appropriate encoding for the file.
        /// </summary>
        /// <param name="srcFile"></param>
        /// <returns></returns>
        public static Encoding GetFileEncoding(string srcFile)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];
            FileStream file = new FileStream(srcFile, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;

            return enc;
        }

        private void addCopyright(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var entireFile = reader.ReadToEnd();
     
                reader.Close();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(copyrightText.Text);
                    writer.Write(entireFile);
                    writer.Close();
                }
            }
        }

        private void checkPackage(string filePath)
        {
            using (Stream reader = new FileStream(filePath, FileMode.Open))
            {
                using (
                    XmlDictionaryReader xmlReader =
                    JsonReaderWriterFactory.CreateJsonReader(reader,
                    new XmlDictionaryReaderQuotas()))
                {
                    XElement root = XElement.Load(xmlReader);
                    XElement form = root.XPathSelectElement("//main");
                    if (form == null || !form.Value.EndsWith("min.js"))
                        problemFiles.Text += filePath + "\r\n";
                }
            }
        }

        private void validatePackages_Click(object sender, EventArgs e)
        {
            if (folderPath.Text != "")
            {
                processStatus.Text = "Working...";
                problemFiles.Text = "";
                string[] fileNames = filesToKeep.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                checkFolder(folderPath.Text, fileNames, true);
                processStatus.Text = "Done";
            }
        }
    }
}
