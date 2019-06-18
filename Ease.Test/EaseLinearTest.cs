﻿namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseLinearTest
    {
        #region In
        [TestMethod]
        public void In_Current1DetlaTime0p1_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 1.0f;
            float deltaTime = 0.1f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current1DetlaTime0p2_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 1.0f;
            float deltaTime = 0.2f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current0p5DetlaTime0p1_0p6()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 0.5f;
            float deltaTime = 0.1f;

            float expected = 0.6f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current0p3DetlaTime0p1_0p4()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 0.3f;
            float deltaTime = 0.1f;

            float expected = 0.4f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current7DetlaTime0p3YScale7TScale3_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 7.0f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current7DetlaTime0p6YScale7TScale3_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 7.0f;
            float deltaTime = 0.6f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current3p5DetlaTime0p3YScale7TScale3_0p6()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 3.5f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.6f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current2p1DetlaTime0p3YScale7TScale3_0p4()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 2.1f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.4f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Current1DetlaTime0p1_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 1.0f;
            float deltaTime = 0.1f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current1DetlaTime0p2_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 1.0f;
            float deltaTime = 0.2f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current0p5DetlaTime0p1_0p6()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 0.5f;
            float deltaTime = 0.1f;

            float expected = 0.6f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current0p3DetlaTime0p1_0p4()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 0.3f;
            float deltaTime = 0.1f;

            float expected = 0.4f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current7DetlaTime0p3YScale7TScale3_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 7.0f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current7DetlaTime0p6YScale7TScale3_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 7.0f;
            float deltaTime = 0.6f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current3p5DetlaTime0p3YScale7TScale3_0p6()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 3.5f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.6f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current2p1DetlaTime0p3YScale7TScale3_0p4()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 2.1f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.4f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Current1DetlaTime0p1_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 1.0f;
            float deltaTime = 0.1f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current1DetlaTime0p2_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 1.0f;
            float deltaTime = 0.2f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current0p5DetlaTime0p1_0p6()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 0.5f;
            float deltaTime = 0.1f;

            float expected = 0.6f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current0p3DetlaTime0p1_0p4()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 0.3f;
            float deltaTime = 0.1f;

            float expected = 0.4f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current7DetlaTime0p3YScale7TScale3_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 7.0f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current7DetlaTime0p6YScale7TScale3_1()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 7.0f;
            float deltaTime = 0.6f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current3p5DetlaTime0p3YScale7TScale3_0p6()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 3.5f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.6f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current2p1DetlaTime0p3YScale7TScale3_0p4()
        {
            Ease.Linear ease = new Ease.Linear();
            float current = 2.1f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.4f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }
        #endregion
    }
}