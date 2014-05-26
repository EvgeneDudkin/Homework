using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventLoop;

namespace EventLoopTests
{
    [TestClass]
    public class EventLoopTests
    {
        [TestMethod]
        public void OnRightTest()
        {
            var eventLoop = new CursorEventLoop();
            var game = new GameWithCursor();
            int position = Console.CursorLeft;
            game.OnRight(new object(), new EventArgs());
            Assert.IsTrue(position + 1 == Console.CursorLeft);
        }

        [TestMethod]
        public void OnLeftTest()
        {
            var eventLoop = new CursorEventLoop();
            var game = new GameWithCursor();
            int position = Console.CursorLeft;
            game.OnRight(new object(), new EventArgs());
            game.OnLeft(new object(), new EventArgs());
            Assert.IsTrue(position == Console.CursorLeft);
        }

        [TestMethod]
        public void OnDownTest()
        {
            var eventLoop = new CursorEventLoop();
            var game = new GameWithCursor();
            int position = Console.CursorTop;
            game.OnDown(new object(), new EventArgs());
            Assert.IsTrue(position + 1 == Console.CursorTop);
        }

        [TestMethod]
        public void OnUpTest()
        {
            var eventLoop = new CursorEventLoop();
            var game = new GameWithCursor();
            int position = Console.CursorLeft;
            game.OnDown(new object(), new EventArgs());
            game.OnUp(new object(), new EventArgs());
            Assert.IsTrue(position == Console.CursorLeft);
        }
    }
}
