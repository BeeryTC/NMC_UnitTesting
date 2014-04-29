using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Friends.Models;
using Friends.Business;

namespace BusinessLayer
{
    [TestClass]
    public class StateServiceTest
    {
        [TestMethod]
        public void States()
        {
            string[] states = StateService.GetAllStates().Select(x => x.StateAbbrev).ToArray();
            CollectionAssert.Contains(states, "MI");
        }
    }
}
