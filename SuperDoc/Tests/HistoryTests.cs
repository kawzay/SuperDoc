using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperDoc.Tests
{
    [TestClass]
    public class HistoryTests
    {
        [TestMethod]
        public void History_KeyDown_WhenTurnEnterAndIndexLessEight_Return()
        {
            var form = new History();
            form.button2 = new Button();
            History.i = 6;
            
            form.History_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }
        [TestMethod]
        public void History_KeyDown_WhenTurnEnterAndIndexMoreEight_Return()
        {
            var form = new History();
            form.button2 = new Button();
            History.i = 12;

            form.History_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }
        [TestMethod]
        public void History_KeyDown_WhenTurnNotEnter_Return()
        {
            var form = new History();
            form.button2 = new Button();

            form.History_KeyDown(null, new KeyEventArgs(Keys.Shift));
        }
    }
}
