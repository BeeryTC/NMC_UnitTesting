using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Friends.Models;

namespace Friends.Business
{
    public static class StateService
    {
        static public List<Friends.Models.State> GetAllStates()
        {
            using (AddressBookContext dataContext = new AddressBookContext())
            {
                return (from s in dataContext.States
                        select s).ToList();
            }

        }
    }
}
