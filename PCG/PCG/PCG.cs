using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCG
{
    public partial class PCG : Form
    {
        public PCG()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox2.Items.Add("Knowledge");
            comboBox2.Items.Add("Comfort");
            comboBox2.Items.Add("Reputation");
            comboBox2.Items.Add("Serenity");
            comboBox2.Items.Add("Protection");
            comboBox2.Items.Add("Conquest");
            comboBox2.Items.Add("Wealth");
            comboBox2.Items.Add("Ability");
            comboBox2.Items.Add("Equipment");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtb1.Text = "";
            Quests(RandomNumberGenerator.NumberBetween(1,10));
        }

        public void Quests(int QuestInputNumber){
            switch (QuestInputNumber)
            {
                case 1:
                    Knowledge KnowledgeQuest = new Knowledge(RandomNumberGenerator.NumberBetween(1, 5));
                    rtb1.Text += KnowledgeQuest.returnMsg(); 
                    break;

                case 2:
                    Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(1, 3));
                    rtb1.Text += ComfortQuest.returnMsg();
                    break;

                case 3:
                    Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(1, 4));
                    rtb1.Text += ReputationQuest.returnMsg();
                    break;

                case 4:
                    Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(1, 8));
                    rtb1.Text += SerenityQuest.returnMsg();
                    break;

                case 5:
                    Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(1, 8));
                    rtb1.Text += ProtectionQuest.returnMsg();
                    break;

                case 6:
                    Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(1, 3));
                    rtb1.Text += ConquestQuest.returnMsg();
                    break;

                case 7:
                    Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(1, 4));
                    rtb1.Text += WealthQuest.returnMsg();
                    break;

                case 8:
                    Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(1, 8));
                    rtb1.Text += AbilityQuest.returnMsg();
                    break;

                case 9:
                    Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(1, 5));
                    rtb1.Text += EquipmentQuest.returnMsg();
                    break;

                default:
                    rtb1.Text += "No motivation have been selected! \n \n";
                    break;
            }
        }

        public void QuestsSelective(int QuestInputNumber)
        {
            switch (QuestInputNumber)
            {
            case 1:
                if (comboBox1.SelectedIndex == 0)
                {
                    Knowledge KnowledgeQuest = new Knowledge(RandomNumberGenerator.NumberBetween(1, 5));
                    rtb1.Text += KnowledgeQuest.returnMsg();
                }
                else
                {
                    Knowledge KnowledgeQuest = new Knowledge(comboBox1.SelectedIndex);
                    rtb1.Text += KnowledgeQuest.returnMsg();
                }
                break;

            case 2:
                if (comboBox1.SelectedIndex == 0)
                {
                    Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(1, 3));
                    rtb1.Text += ComfortQuest.returnMsg();
                }
                else
                {
                    Comfort ComfortQuest = new Comfort(comboBox1.SelectedIndex);
                    rtb1.Text += ComfortQuest.returnMsg();
                }
                break;

            case 3:
                if (comboBox1.SelectedIndex == 0)
                {
                    Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(1, 4));
                    rtb1.Text += ReputationQuest.returnMsg();
                }
                else
                {
                    Reputation ReputationQuest = new Reputation(comboBox1.SelectedIndex);
                    rtb1.Text += ReputationQuest.returnMsg();
                }
                break;

            case 4:
                if (comboBox1.SelectedIndex == 0)
                {
                    Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(1, 8));
                    rtb1.Text += SerenityQuest.returnMsg();
                }
                else
                {
                    Serenity SerenityQuest = new Serenity(comboBox1.SelectedIndex);
                    rtb1.Text += SerenityQuest.returnMsg();
                }
                break;

            case 5:
                if (comboBox1.SelectedIndex == 0)
                {
                    Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(1, 8));
                    rtb1.Text += ProtectionQuest.returnMsg();
                }
                else
                {
                    Protection ProtectionQuest = new Protection(comboBox1.SelectedIndex);
                    rtb1.Text += ProtectionQuest.returnMsg();
                }
                break;

            case 6:
                if (comboBox1.SelectedIndex == 0)
                {
                    Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(1, 3));
                    rtb1.Text += ConquestQuest.returnMsg();
                }
                else
                {
                    Conquest ConquestQuest = new Conquest(comboBox1.SelectedIndex);
                    rtb1.Text += ConquestQuest.returnMsg();
                }
                break;

            case 7:
                if (comboBox1.SelectedIndex == 0)
                {
                    Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(1, 4));
                    rtb1.Text += WealthQuest.returnMsg();
                }
                else
                {
                    Wealth WealthQuest = new Wealth(comboBox1.SelectedIndex);
                    rtb1.Text += WealthQuest.returnMsg();
                }
                break;

            case 8:
                if (comboBox1.SelectedIndex == 0)
                {
                    Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(1, 8));
                    rtb1.Text += AbilityQuest.returnMsg();
                }
                else
                {
                    Ability AbilityQuest = new Ability(comboBox1.SelectedIndex);
                    rtb1.Text += AbilityQuest.returnMsg();
                }
                break;

            case 9:
                if (comboBox1.SelectedIndex == 0)
                {
                    Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(1, 5));
                    rtb1.Text += EquipmentQuest.returnMsg();
                }
                else
                {
                    Equipment EquipmentQuest = new Equipment(comboBox1.SelectedIndex);
                    rtb1.Text += EquipmentQuest.returnMsg();
                }
                break;

            default:
                rtb1.Text += "No motivation have been selected! \n \n";
                break;
            }
        }

        /// <summary>
        /// Used to keep the Rich Text Box (Text log) scrolling down automatically
        /// </summary>
        private void ScrollToBottomOfMessages()
        {
            rtb1.SelectionStart = rtb1.Text.Length;
            rtb1.ScrollToCaret();
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            ScrollToBottomOfMessages();
        }

        public void MoveTo(Location newLocation)
        {
            Location Currentlocation = newLocation;
            String whatever = World.LocationByID(5).LocationName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtb1.Text = "";
            QuestsSelective(comboBox2.SelectedIndex + 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
            }

            if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
            }

            if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
            }

            if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
            }

            if (comboBox2.SelectedIndex == 4)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
            }

            if (comboBox2.SelectedIndex == 5)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
            }

            if (comboBox2.SelectedIndex == 6)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
            }

            if (comboBox2.SelectedIndex == 7)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
            }

            if (comboBox2.SelectedIndex == 8)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Random");
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
            }
        }
    }
}
