/********************************************************************************
 * Friends 
 * Bethany Beery | Northwestern Michigan College
 * Sept 17th 2013
 * 
 * Revised April 20th to implement mutlti-tier architecture, unit testing, and entity framework
 * 
 * Sample image "Hawaiian Girl" courtesy Photobucket
 * Retrieved 9/17/2013 from http://s406.photobucket.com/user/krachjoschi/media/hawaiian-girl-1.jpg.html
 * 
 * Music from https://www.youtube.com/watch?v=MR2V_3-B8y4
 * History of the Dashboard Hula Girl by OnStar
 *******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Friends; 
using System.Linq;
using System.Media;
using PersonInfo; 
using System.Text;
using System.Windows.Forms;
using Friends.Properties;
using Friends.Models;
using Friends.Business;

namespace Friends
{
    public partial class frmMain : Form
    {
        SoundPlayer HawiianPlayer = new SoundPlayer(Resource1.Hawiian);
        public List<Friend> FriendList = new List<Friend>();
        public List<State> StateList = new List<State>();

        public frmMain()
        {
            InitializeComponent();
            fill_StateComboBox();
            Fill_lstBoxFriends();
            HawiianPlayer.PlayLooping();
        }

        // Custom method to add new contact to list box
        public void Fill_lstBoxFriends()
        {
            lstBoxFriends.Items.Clear();
            foreach (Friend f in FriendList)
            {
                lstBoxFriends.Items.Add(f.ToString());
            }
        }

        public void fill_StateComboBox()
        {
            List<string> states = new List<string>();
            states = StateService.GetAllStates().Select(x => x.StateAbbrev).ToList();
            cbStateAbbrevs.DataSource = states;
            cbStateAbbrevs.DisplayMember = "StateAbb";
        }

        private void lstBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            Friend selected = FriendList[lstBoxFriends.SelectedIndex];

            txtFirstName.Text = selected.FirstName;
            txtLastName.Text = selected.Street;
            txtStreet.Text = selected.Street;
            cbStateAbbrevs.Text = selected.State;
            txtZip.Text = selected.Zip.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text.Trim().Length == 0  || txtLastName.Text.Trim().Length == 0 || txtStreet.Text.Trim().Length == 0 || txtZip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                else
                {
                     Friend newfriend = new Friend()
                     {
                          FirstName = txtFirstName.Text,
                          LastName = txtLastName.Text,
                          Street = txtStreet.Text,
                          State = cbStateAbbrevs.Text,
                          Zip =Convert.ToInt32(txtZip.Text),
                      };

                     Business.FriendCRUD friendCRUD = new Business.FriendCRUD();
                     friendCRUD.AddFriend(newfriend);

                     MessageBox.Show("New friend was successfully added", "Successful Add", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                     // Add new Friend to list box
                     Fill_lstBoxFriends();

                     // Clear text boxes to be ready for next entry
                     txtFirstName.Clear();
                     txtLastName.Clear();
                     txtStreet.Clear();
                     txtZip.Clear();
                  }
             }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Remove friend from listbox and list collection
            int selectedIndex = lstBoxFriends.SelectedIndex;

            Business.FriendCRUD fr = new Business.FriendCRUD();

            try
            {
                Friend friend = lstBoxFriends.SelectedItem as Friend;
                fr.DeleteFriend(friend);
                Fill_lstBoxFriends();         
       
                FriendList.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("Select a friend to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 


        #region Music
        private void radbtnOn_CheckedChanged(object sender, EventArgs e)
        {
            HawiianPlayer.PlayLooping();
        }

        private void radbtnOff_CheckedChanged(object sender, EventArgs e)
        {
            HawiianPlayer.Stop();
        }
        #endregion










    }
}