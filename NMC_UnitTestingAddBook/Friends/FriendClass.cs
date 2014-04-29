using System;
using System.Collections.Generic;
using System.Globalization; 
using System.Linq;
using PersonInfo; 
using System.Text;

namespace Friends
{
    public class FriendContact
    {
        #region [Private Fields]
        private string _name;
        private Address _location; //an instance of AddressClassLibrary
        private string _photo; // will hold file path and file name to an external graphic file 
        #endregion

        #region [Internal Data]
        private TextInfo ti = new CultureInfo("en-US", false).TextInfo;
        #endregion

        #region [Business Rules - Default Friend]
        // Default Friend to appear at start
        public static readonly string DefaultName = " ";
        private static readonly Address DefaultAddress = null;
        private static readonly string DefaultPhoto = null;
        #endregion

        #region [Public Properties]
        public string Name
        {
            get { return _name; }
            set { _name = ti.ToTitleCase(value.Trim()); }
        }

        public Address Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        } 
        #endregion

        #region Public Constructors

        public FriendContact() // default constructor
        //: this(DefaultName, DefaultAddress, DefaultPhot)
        {
            this.Name = "";
            this.Location = null;
            this.Photo = null;
        }

        public FriendContact(string name) // takes one parameter
        {
            this.Name = name;
            this.Location = DefaultAddress;
            this.Photo = DefaultPhoto;
        }

        public FriendContact(string name, Address location) // takes two parameters
           : this(name)
        {
            this.Location = location;
        }


        #endregion

        #region Public Methods
        public override string ToString()
        {
            return string.Format("{0}\n,{1}", this.Name, this.Location.ToString());
        }

        public string ToString(string sep)
        {
            return string.Format("{0}{4}{1}{4}", this.Name, this.Location.ToString());
        } 
        #endregion

    }
}
