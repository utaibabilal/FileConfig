using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        
            public
             Label TxtLabel;
            public
            TextBox TextBox;
        
        //============ declerations======
        bool[] tabState = new bool[5];
        int distance = 0;
        String strSection = "";
        
       
        //===============================
        public Form1()
        {
            InitializeComponent();
            String strSection = "screen";
            this.ReadXmlFileUsingXDocument(strSection);  // file reading
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

           // String strSection = "screen";
           // this.ReadXmlFileUsingXDocument(strSection);  // file reading
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        public void ReadXmlFileUsingXDocument(String strSection)
        {
            XElement root = XElement.Load("D:\\Amazonserver.xml");
            IEnumerable<XElement> Section =
                from el in root.Elements("Section")
                where (string)el.Attribute("Type") == strSection
                select el;
            foreach (XNode node in Section)
            {
              

                foreach (XNode subNode in (node as XElement).Nodes())
                {
                    string strCtrlType = (subNode as XElement).Attribute("ctrlType").Value;  

                    string strname = (subNode as XElement).Name.ToString();

                    string strvalue = (subNode as XElement).Value.ToString();

                    PopulateResourcesOnDialog(strname, strvalue , strCtrlType);

                }
             
            }

            
        }



        public void ReadMaevexSetting()
        {
           
            XmlDocument doc = new XmlDocument();
            XmlNamespaceManager namespaces = new XmlNamespaceManager(doc.NameTable);
            namespaces.AddNamespace("ns", "urn:hl7-org:v3");
            doc.Load("D:\\Amazonserver.xml");
            XmlNode idNode = doc.SelectSingleNode("/office/Maevex", namespaces);
            XmlNode desiredNode = null;
            if (idNode.HasChildNodes)
            {
               foreach (XmlNode childNode in idNode.ChildNodes)
               {
                  string str =  childNode.Name.ToString();

                  if (str == "view2")
                  {
                      desiredNode = childNode;
                  }
               }
               if (desiredNode != null)
               {
                   idNode.RemoveChild(desiredNode);
               }
            }

            doc.Save(@"D:\\Amazonserver.xml");
        }

        public void PopulateResourcesOnDialog(string strName , string strValue , string strCtrlType)
        {
            TabPage tp = tabControlMain.SelectedTab;

            switch (strCtrlType)
            {
                case "TextBox":
                    TextBox txtBox = new TextBox();
                    tp.Controls.Add(txtBox);
                    txtBox.Text = "TextBox";
                    distance = distance + 30;
                    txtBox.Top = distance;
                    txtBox.Left = 30;

                    break;
                case "StaticText":
                    Label labelOne = new Label();
                    tp.Controls.Add(labelOne);
                    labelOne.Text = "StaticText";
                    distance = distance + 30;
                    labelOne.Top = distance;
                    labelOne.Left = 30;

                    break;
                case "CheckBox":
                    CheckBox checkBoxOne = new CheckBox();
                    tp.Controls.Add(checkBoxOne);
                    checkBoxOne.Text = "CheckBox";
                    distance = distance + 30;
                    checkBoxOne.Top = distance;
                    checkBoxOne.Left = 30;

                    break;
                case "ComboBox":
                    ComboBox combo = new ComboBox();
                    tp.Controls.Add(combo);
                    combo.Text = "ComboBox";
                    distance = distance + 30;
                    combo.Top = distance;
                    combo.Left = 30;
                    break;

                default:
                    break;
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Screen_Click(object sender, EventArgs e)
        {
                
        }

        private void Disco_Click(object sender, EventArgs e)
        {

        }

        private void Network_Click(object sender, EventArgs e)
        {

        }

        private void Assets_Click(object sender, EventArgs e)
        {
            
        }

        private void AmazonConsole_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
            
        }

        private void AmazonServer_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
            
        }

        private void AmazonReplay_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
           
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:

                    tabState[0] = true;
                    tabState[1] = false;
                    tabState[2] = false;
                    tabState[3] = false;
                    tabState[4] = false;

                    strSection = "screen";
                    distance = 0;
                    this.ReadXmlFileUsingXDocument(strSection);  // file reading
                    break;
                case 1:
                    tabState[0] = false;
                    tabState[1] = true;
                    tabState[2] = false;
                    tabState[3] = false;
                    tabState[4] = false;
                    distance = 0;
                   // strSection = "drum";
                   // this.ReadXmlFileUsingXDocument(strSection);  // file reading
                    break;
                case 2:
                    tabState[0] = false;
                    tabState[1] = false;
                    tabState[2] = true;
                    tabState[3] = false;
                    tabState[4] = false;
                    distance = 0;
                   //  strSection = "network";
                   // this.ReadXmlFileUsingXDocument(strSection);  // file reading
                    break;
                case 3:
                    tabState[0] = false;
                    tabState[1] = false;
                    tabState[2] = false;
                    tabState[3] = true;
                    tabState[4] = false;
                    distance = 0;
                   // strSection = "database";
                   // this.ReadXmlFileUsingXDocument(strSection);  // file reading
                    break;
                case 4:
                    tabState[0] = false;
                    tabState[1] = false;
                    tabState[2] = false;
                    tabState[3] = false;
                    tabState[4] = true;
                    distance = 0;
                    // strSection = "assets";
                    //this.ReadXmlFileUsingXDocument(strSection);  // file reading
                    break;

                case 5:
                    distance = 0;
                   // strSection = "misc";
                   // this.ReadXmlFileUsingXDocument(strSection);  // file reading
                    break;
            }
        }

        public void GetControl()
        {
            Label lbl = null;
            TabPage tp = tabControlMain.SelectedTab;

            if(tp != null)
            {
                foreach(var tab in tp.Controls)
                {
                    string def = tab.GetType().ToString();
                    Label l1 = (Label)tab;
                    l1.Text = "Vision";
                }
                 lbl = tp.Controls[0] as Label;

              
              
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadMaevexSetting();
        }


     
        
    }
}
