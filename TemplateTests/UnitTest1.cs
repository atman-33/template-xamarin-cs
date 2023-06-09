using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.ViewModels;

namespace TemplateTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 起動時はCCCでボタンを押したらEEEになる()
        {
            var vm = new Page001ViewModel(null,null);
            Assert.AreEqual("DDD", vm.LabelC);

            vm.ButtonC.Execute();
            Assert.AreEqual("EEE", vm.LabelC);
        }
    }
}
