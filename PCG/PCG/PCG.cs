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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtb1.Text += "NEW QUEST!\n";
            Quests(RandomNumberGenerator.NumberBetween(0,9));
        }

        public void Quests(int QuestInputNumber){
            switch (QuestInputNumber + 1)
            {
            case 1:
                Knowledge KnowledgeQuest = new Knowledge(RandomNumberGenerator.NumberBetween(0, 4));
                rtb1.Text += KnowledgeQuest.returnMsg();
                break;

            case 2:
                Comfort ComfortQuest = new Comfort(RandomNumberGenerator.NumberBetween(0, 2));
                rtb1.Text += ComfortQuest.returnMsg();
                break;

            case 3:
                Reputation ReputationQuest = new Reputation(RandomNumberGenerator.NumberBetween(0, 3));
                rtb1.Text += ReputationQuest.returnMsg();
                break;

            case 4:
                Conquest ConquestQuest = new Conquest(RandomNumberGenerator.NumberBetween(0, 2));
                rtb1.Text += ConquestQuest.returnMsg();
                break;

            case 5:
                Wealth WealthQuest = new Wealth(RandomNumberGenerator.NumberBetween(0, 3));
                rtb1.Text += WealthQuest.returnMsg();
                break;

            case 6:
                Equipment EquipmentQuest = new Equipment(RandomNumberGenerator.NumberBetween(0, 4));
                rtb1.Text += EquipmentQuest.returnMsg();
                break;

            case 7:
                Ability AbilityQuest = new Ability(RandomNumberGenerator.NumberBetween(0, 7));
                rtb1.Text += AbilityQuest.returnMsg();
                break;

            case 8:
                Serenity SerenityQuest = new Serenity(RandomNumberGenerator.NumberBetween(0, 7));
                rtb1.Text += SerenityQuest.returnMsg();
                break;

            case 9:
                Protection ProtectionQuest = new Protection(RandomNumberGenerator.NumberBetween(0, 7));
                rtb1.Text += ProtectionQuest.returnMsg();
                break;

            default:
                rtb1.Text += "SOMETHING HAVE GONE WRONG";
                rtb1.Text += "SOMETHING HAVE GONE WRONG";
                rtb1.Text += "SOMETHING HAVE GONE WRONG";
                rtb1.Text += "SOMETHING HAVE GONE WRONG";
                rtb1.Text += "SOMETHING HAVE GONE WRONG";
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
    }
}
