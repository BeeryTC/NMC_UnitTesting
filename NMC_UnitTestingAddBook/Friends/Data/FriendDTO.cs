using System;
using System.Collections.Generic;
using System.Globalization; 
using System.Linq;
using System.Text;
using PersonInfo;
using Friends;

namespace Friends.Data
{
    public class FriendDTO
    {
            #region [Private Fields]
            private string _firstName;
            private string _lastName;
            private string _street;
            private string _state;
            private int? zip;
            private Address _location; //an instance of AddressClassLibrary
            private string _photo; // will hold file path and file name to an external graphic file 
            #endregion

            #region [Internal Data]
            private TextInfo ti = new CultureInfo("en-US", false).TextInfo;
            #endregion

            #region [Business Rules - Default Friend]
            // Default Friend to appear at start
            public static readonly string DefaultFirstName = " ";
            public static readonly string DefaultLastName = " ";
            private static readonly Address DefaultAddress = null;
            private static readonly string DefaultPhoto = null;
            #endregion

            #region [Public Properties]
            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = ti.ToTitleCase(value.Trim()); }
            }

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = ti.ToTitleCase(value.Trim()); }
            }

            public string Street
            {
                get { return _street; }
                set { _street = value; }
            }

            public string State
            {
                get { return _state; }
                set { _state = value; }
            }

            public int? Zip
            {
                get { return zip; }
                set { zip = value; }
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

            public FriendDTO() // default constructor
            //: this(DefaultName, DefaultAddress, DefaultPhot)
            {
                this.FirstName = string.Empty;
                this.LastName = string.Empty;
                this.Street = string.Empty;
                this.Photo = string.Empty;
                this.Zip = null;
            }

            public FriendDTO(string firstname) // takes one parameter
            {
                this.FirstName = "";
                this.LastName = "";
                this.Location = DefaultAddress;
                this.Photo = DefaultPhoto;
            }

            public FriendDTO(string fisrtname, Address location) // takes two parameters
                : this(fisrtname)
            {
                this.Location = location;
            }


            #endregion

            #region Public Methods
            public override string ToString()
            {
                return string.Format("{0}\n,{1}", this.FirstName, this.LastName.ToString());
            }

            public string ToString(string sep)
            {
                return string.Format("{0}{4}{1}{4}", this.FirstName, this.LastName.ToString());
            }
            #endregion

     }
    
}