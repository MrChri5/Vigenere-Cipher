using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] autoAddText = { "_______", "" };
        bool editing = false;

        //arbitrary max number of keywords
        int noKeys = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            // auto-add item
            keywordList.Items.Clear();
            ListViewItem autoAdd = new ListViewItem(autoAddText);
            keywordList.Items.Add(autoAdd);
        }

        private void keywordList_ItemActivate(object sender, EventArgs e)
        {
            //set activated item to edit mode
            if (keywordList.SelectedItems.Count == 1)
            {
                keywordList.SelectedItems[0].BeginEdit();
            }
        }

        private void keywordList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            //add new auto-add row if last row was edited
            editing = false;
            if (e.Label != null && keywordList.SelectedIndices[0] == keywordList.Items.Count - 1)
            {
                ListViewItem autoAdd = new ListViewItem(autoAddText);
                keywordList.Items.Add(autoAdd);                
            }
        }

        private void keywordList_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            // set editing flag to prevent focus leaving listview before formatting
            editing = true;
        }

        private void keywordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!editing)
            {

                for (int i = 0; i < keywordList.Items.Count - 1; i++)
                {
                    //format each entry to remove special characters
                    string newText = KeywordEdit(keywordList.Items[i].Text);
                    if (newText == "")
                    {
                        //remove any blank items, except the auto-add row
                        keywordList.Items.RemoveAt(i);
                    }
                    else if (newText != keywordList.Items[i].Text)
                    {
                        //Add length as subitem
                        string[] newItemText = { newText, newText.Length.ToString() };
                        ListViewItem newItem = new ListViewItem(newItemText);
                        newItem.Selected = keywordList.Items[i].Selected;
                        keywordList.Items[i] = newItem;
                    }
                }
                //redisplay cipher strength
                CalculateStats();
            }
        }

        private void keywordList_Validating(object sender, CancelEventArgs e)
        {
            //if editing don't leave the listview
            e.Cancel = editing;
        }

        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            //load .txt file into input textbox        
            string openFilePath = "";
            openFileDialog1.Filter = "Text file|*.txt";
            openFileDialog1.Title = "Open text file";

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                openFilePath = openFileDialog1.FileName;
                System.IO.StreamReader streamReader = new System.IO.StreamReader(openFilePath);
                InputBox.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            //save output textbox to .txt file
            string saveFilePath = "";
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save text file";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                saveFilePath = saveFileDialog1.FileName;
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFilePath);
                streamWriter.WriteLine(OutputBox.Text);
                streamWriter.Close();
            }
        }

        private string KeywordEdit(string inputKeyword)
        {
            //remove any special characters and convert to upper
            string newKeyword = "";
            for (int i = 0; i < inputKeyword.Length; i++)
            {
                if (inputKeyword[i] >= 'A' && inputKeyword[i] <= 'Z' || inputKeyword[i] >= 'a' && inputKeyword[i] <= 'z')
                {
                    newKeyword += inputKeyword[i];
                }
            }
            return newKeyword.ToUpper();
        }

        private void CalculateStats(object sender, EventArgs e)
        {
            CalculateStats();
        }
        private void CalculateStats()
        {
            int[] keyLengths = new int[noKeys];
            //read lengths of keywords from list
            for(int i = 0;i < keyLengths.Length; i++)
            {
                if (i < keywordList.Items.Count && keywordList.Items[i].Text != autoAddText[0])
                {
                    keyLengths[i] = keywordList.Items[i].Text.Length;
                }
                //for lcm calculations, length 0 has lcm 1
                if (keyLengths[i] == 0)
                {
                    keyLengths[i] = 1;
                }
            }
            //cipher strength = lcm of all keyword lengths
            int cipherStrength = Lcm(keyLengths);
            lcm.Text = cipherStrength.ToString();
            //calculate number of letters in message
            //N.B cipher replaces all other characters with space and doesn't format into blocks 
            int msgLength = 0;
            for (int i = 0; i < InputBox.TextLength; i++)
            {
                //keywords already converted to uppercase
                if (InputBox.Text[i] >= 'A' && InputBox.Text[i] <= 'Z')
                {
                    msgLength++;
                }
            }
            msgLengthLbl.Text = msgLength.ToString();
            //display cipher strength vs message length as a progress bar
            progressBar1.Value = 0;
            if (msgLength != 0)
            {
                progressBar1.Value = Math.Min(progressBar1.Maximum, (100 * cipherStrength) / msgLength);
            }                               
        }

        //Lowest Common Multiple
        //multiple values
        private int Lcm(int[] xArray)
        {
            //LCM(x,y,z) = LCM(LCM(x,y),z)
            int lcmValue = 1;
            for (int i = 0; i < xArray.Length; i++)
            {
                lcmValue = Lcm(lcmValue, xArray[i]);
            }
            return lcmValue;
        }
        //pair of values
        private int Lcm(int x, int y)
        {
            //take abs of values
            if (x < 0)
            {
                x *= -1;
            }
            if (y < 0)
            {
                y *= -1;
            }

            //lcm for two positve integers
            int lcmValue = x * y;
            int xRem;
            int yRem;

            for (int i = 2; i <= x && i <= y;)
            {
                Math.DivRem(x, i, out xRem);
                Math.DivRem(y, i, out yRem);
                if (xRem == 0 && yRem == 0)
                {
                    x /= i;
                    y /= i;
                    lcmValue /= i;
                }
                else
                {
                    i++;
                }
            }
            return lcmValue;
        }

        //perform decode by setting encodeDecode to false
        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            encode(false);
        }
        //perform encode by setting encodeDecode to true
        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            encode(true);
        }

        private void encode(bool encodeDecode)
        {
            //encode or decode message
            int encodePtr = -1;
            if (encodeDecode)
            {
                encodePtr = 1;
            }
            string messageText = InputBox.Text;
            string cipherText = "";      
            string[] keys = new string[noKeys];
            int[] keyCounters = new int[noKeys];
            //read keys and initialize key counters
            for (int i = 0; i < keys.Length; i++)
            {
                if (i < keywordList.Items.Count)
                {
                    keys[i] = KeywordEdit(keywordList.Items[i].Text);
                    keyCounters[i] = 0;
                }
                //empty keys are replaced with identity key 'Z'
                if (keys[i] == "" || keys[i] == null)
                {                  
                    keys[i] = "Z";
                }
            }
            int cipherLetterValue = 0;
            int cipherFormatPtr = 0;
            foreach (char msgLetter in messageText)
            {
                //skip special characters and replace with spaces
                if (msgLetter < 'A' || msgLetter > 'Z')
                {
                    if (!cipherFormat.Checked || !encodeDecode)
                    {
                        cipherText += " ";
                    }
                    continue;
                }
                cipherLetterValue = (int)msgLetter;
                //add keyword letters to message letter to obtain cipher letter or reverse if decoding
                for (int i = 0; i < keys.Length; i++)
                {
                    cipherLetterValue += (int)encodePtr * ((keys[i])[keyCounters[i]] - 'A' + 1);
                    keyCounters[i]++;
                    if (keyCounters[i] == keys[i].Length)
                    {
                        keyCounters[i] = 0;
                    }
                }
                //bring char value back into uppercase letter range
                while (cipherLetterValue < (int)'A' || cipherLetterValue > (int)'Z')
                {
                    cipherLetterValue -= encodePtr * 26; // would not work in EBCDIC as A-Z is not continuous
                }
                cipherText += ((char)cipherLetterValue).ToString();
                // Add a space every five letters if Ciphertext Format is checked
                ++cipherFormatPtr;
                if (cipherFormatPtr == 5 && cipherFormat.Checked && encodeDecode)
                {
                    cipherText += " ";
                    cipherFormatPtr = 0;
                }
            }
            //if using Ciphertext format, add characters to make up final block
            if(cipherFormat.Checked && encodeDecode && cipherFormatPtr !=0)
            {
                while(cipherFormatPtr < 5)
                {
                    cipherText += "X";
                    ++cipherFormatPtr;
                }
            }

            //display message in output textbox 
            OutputBox.Text = cipherText;
        }
    }
}
