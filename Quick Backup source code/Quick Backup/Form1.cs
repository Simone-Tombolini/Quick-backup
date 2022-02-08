//Quick backup
//this proogram is a simple tool tath allow to copy a source directory in a destination directory
//and remember a default path.
//for security reason the program must be installed, run and it can manipulate file only in standard user directory

//date: 08/02/2022

//totaly free license 

//developed by Tombolini Simone

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Backup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {

                //get the path of the .exe file thath will be runned
                string EXEPath = "";
                EXEPath = System.Reflection.Assembly.GetEntryAssembly().Location;

                //generate the path of the setup.bat file
                string BATPath = EXEPath;
                BATPath = BATPath.Remove(EXEPath.Length - 17, 17);
                BATPath = BATPath.Replace('\\', '/');
                BATPath = BATPath + "/setup.bat";

                //generate the path of the save.txt file
                string SAVEPath = "";
                SAVEPath = EXEPath.Remove(EXEPath.Length - 17, 17);
                SAVEPath = SAVEPath.Replace('\\', '/');
                SAVEPath = SAVEPath + "/save.txt";

                //unenable the textbox 
                textBoxSouce.Enabled = false;
                textBoxDestination.Enabled = false;
                
                bool error = false; //error loading file, number lines >=4 
                //load from the save.txt file the deafult path
                using (StreamReader reader = new StreamReader(SAVEPath))
                {
                    string line; //value of the courrent cycle
                    int c = 1;//counter
                   
                    while ((line = reader.ReadLine()) != null)
                    {
                        //check if exist a default path
                        if (c == 1 && line == "flag")
                        {
                            checkBoxDefault.Checked = true;
                        }
                        //load the default source path
                        if (c == 2 && checkBoxDefault.Checked == true)
                        {
                            textBoxSouce.Text = line;
                        }
                        //load the default destination path
                        if (c == 3 && checkBoxDefault.Checked == true)
                        {
                            textBoxDestination.Text = line;
                        }
                        //error message
                        if (c >= 4)
                        {

                            error = true;
                        }
                        c++;
                    }
                   
                }
                //error 
                if (error == true)
                {
                    //show a a error message
                    MessageBox.Show(
                        "Error loading save file",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    //get empty the save.txt file
                    string[] savelines = { "" };

                    string savePath = SAVEPath;

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(savePath, "")))
                    {
                        foreach (string Blankline in savelines)
                            outputFile.WriteLine(Blankline);
                    }
                }
            }
            catch
            {
                //show error message
                MessageBox.Show(
                    "Error in program initialization,\n reinstall correctly the program", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                
                //close the program
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
        }

        //button Run
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //confirm the opertation message
                DialogResult result = MessageBox.Show(
                    "Do you confirm the operation of the program? \nThe files in the source folder: '\n\n" + 
                    textBoxSouce.Text + 
                    "\n\nwill be copied to the destination folder:\n\n" + 
                    textBoxDestination.Text + 
                    "\n\nIf the paths are not valid the program will have no effect.",
                    "Conferma", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                
                //if user confirm the operation exegute the program, else show cancel message
                if (result == DialogResult.Yes)
                {
                    //get the path of the .exe file thath will be runned
                    string EXEPath = "";
                    EXEPath = System.Reflection.Assembly.GetEntryAssembly().Location;

                    //generate the path of the setup.bat file
                    string BATPath = EXEPath;
                    BATPath = BATPath.Remove(EXEPath.Length - 17, 17);
                    BATPath = BATPath.Replace('\\', '/');
                    BATPath = BATPath + "/setup.bat";

                    //generate the path of the save.txt file
                    string SAVEPath = "";
                    SAVEPath = EXEPath.Remove(EXEPath.Length - 17, 17);
                    SAVEPath = SAVEPath.Replace('\\', '/');
                    SAVEPath = SAVEPath + "/save.txt";

                    //if this path is the deafult save that in the save.txt file
                    if (checkBoxDefault.Checked == true)
                    {
                        //the save.txt file have 3 line,
                        //first: control line "flag"
                        //second: source path
                        //third: destination path
                        string[] savelines = { 
                                "flag", 
                                textBoxSouce.Text, 
                                textBoxDestination.Text };

                        //saving the lines
                        string savePath = SAVEPath;

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(savePath, "")))
                        {
                            foreach (string line in savelines)
                                outputFile.WriteLine(line);
                        }
                    }

                    //creating the robocopy command
                    string RobocopyString = "";

                    //structure of robocopy:
                    //"robocopy" source_path destination_path /W:1 /R:2 /XO
                    // W:1 - specifies to wait 1 second between retries when copying files
                    // R:2 - specifies the number of retries on failed copies
                    // XO - This excludes older files/folders if the destination file/folder exists and is the same date

                    RobocopyString = "robocopy " + textBoxSouce.Text + " " + textBoxDestination.Text + " /W:1 /R:2 /XO";

                    string[] lines = { RobocopyString };


                    string docPath = BATPath;

                    //writing the setup.bat file whith the command robocopy
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "")))
                    {
                        foreach (string line in lines)
                            outputFile.WriteLine(line);
                    }

                    //executing the setup.bat file
                    System.Diagnostics.Process.Start(BATPath);

                    //close the program
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        System.Environment.Exit(1);
                    }
                }
                else
                {
                    //cancel operation message
                    MessageBox.Show(
                        "Operation canceled", 
                        "Warning", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                }
        }
            catch
            {
                //generic error
                MessageBox.Show(
                    "Generic error if the problem persists uninstall and reinstall the program", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
}
        //search source button
        private void buttonSearchSource_Click(object sender, EventArgs e)
        {
            //get the selected path from usere and put into the source textbox
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSouce.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //search destianation button
        private void buttonSearchDestiantion_Click(object sender, EventArgs e)
        {
            //get the selected path from usere and put into the destiantion textbox
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //modify source checkbox 
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //enable/unenable the source textbox
            if (checkBox2.Checked == true)
            {
                textBoxSouce.Enabled = true;
            }
            else
            {
                textBoxSouce.Enabled = false;
            }
        }
        //modify destination checkbox 
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            //enable/unenable the destination textbox
            if (checkBox3.Checked == true)
            {
                textBoxDestination.Enabled = true;
            }
            else
            {
                textBoxDestination.Enabled = false;
            }
        }
    }
}