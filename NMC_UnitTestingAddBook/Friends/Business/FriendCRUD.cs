using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Friends;
using Friends.Models;

namespace Friends.Business
{
    class FriendCRUD
    {
        
        public List<Friend> GetAllFriends()
        {
            using (AddressBookContext dataContext = new AddressBookContext())
            {
                return (from friend in dataContext.Friends
                        orderby friend.FirstName
                        select new Friend
                        {
                            FirstName = friend.FirstName,
                            LastName = friend.LastName,
                            Street = friend.Street,
                            State = friend.State,
                            Zip = friend.Zip,
                        }).ToList();
            }
        }

        public void AddFriend(Friend newFriend)
        {
            using (AddressBookContext dataContext = new AddressBookContext())
            {
                Friend friend = new Friend
                {
                    FirstName = newFriend.FirstName,
                    LastName = newFriend.LastName,
                    Street = newFriend.Street,
                    State = newFriend.State,
                    Zip = newFriend.Zip,
                };
                dataContext.Friends.Add(friend);
                dataContext.SaveChanges();
            }
        }

        public void UpdateFriend(Friend updatefriend)
        {
            using (AddressBookContext dataContext = new AddressBookContext())
            {
                Friend friendToUpdate = dataContext.Friends.Single(t => t.FirstName == updatefriend.FirstName);
                updatefriend.FirstName = updatefriend.FirstName;
                updatefriend.LastName = updatefriend.LastName;
                updatefriend.Street = updatefriend.Street;
                updatefriend.State = updatefriend.State;
                updatefriend.Zip = updatefriend.Zip;

                dataContext.SaveChanges();
            }
        }

        public void DeleteFriend(Friend deleteFriend)
        {
            using (AddressBookContext dataContext = new AddressBookContext())
            {
                Friend friendToDelete = dataContext.Friends.Single(t => t.ID == deleteFriend.FirstName);
                dataContext.Friends.Remove(friendToDelete);
                dataContext.SaveChanges();
            }
        }
    }
}
