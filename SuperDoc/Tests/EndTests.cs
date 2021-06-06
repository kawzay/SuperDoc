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
    public class EndTests
    {
        [TestMethod]
        public void End_KeyDown_WhenTurnEnterAndIndexLessThat11_Return()
        {
            var form = new End();
            End.i = 1;
            form.lable2 = new System.Windows.Forms.Label();

            form.End_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }
        [TestMethod]
        public void End_KeyDown_WhenTurnEnterAndIndexEqualThat11_Return()
        {
            var form = new End();
            End.i = 11;
            form.lable2 = new System.Windows.Forms.Label();

            form.End_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }
    }
}
