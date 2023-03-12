using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.ViewModels;

namespace TemplateTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ‹N“®Žž‚ÍCCC‚Åƒ{ƒ^ƒ“‚ð‰Ÿ‚µ‚½‚çEEE‚É‚È‚é()
        {
            var vm = new MainPageViewModel(null);
            Assert.AreEqual("DDD", vm.LabelC);

            vm.ButtonC.Execute();
            Assert.AreEqual("EEE", vm.LabelC);
        }
    }
}
