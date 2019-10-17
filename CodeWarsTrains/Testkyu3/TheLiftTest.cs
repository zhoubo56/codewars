using kyu3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu3
{
    [TestClass]
    public class TheLiftTest
    {
        [TestMethod]
        public void TestUp()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[0], // 1
                new int[]{5,5,5}, // 2
                new int[0], // 3
                new int[0], // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 2, 5, 0 }, result);
        }

        [TestMethod]
        public void TestDown()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[0], // 1
                new int[]{1,1}, // 2
                new int[0], // 3
                new int[0], // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 2, 1, 0 }, result);
        }

        [TestMethod]
        public void TestUpAndUp()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[]{3}, // 1
                new int[]{4}, // 2
                new int[0], // 3
                new int[]{5}, // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 1, 2, 3, 4, 5, 0 }, result);
        }

        [TestMethod]
        public void TestDownAndDown()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[]{0}, // 1
                new int[0], // 2
                new int[0], // 3
                new int[]{2}, // 4
                new int[]{3}, // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 5, 4, 3, 2, 1, 0 }, result);
        }

        [TestMethod]
        public void TestEnterOnGroundFloor()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[]{1,2,3,4}, // 1
                new int[0], // 2
                new int[0], // 3
                new int[0], // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 1, 2, 3, 4, 1, 0 }, result);
        }

        [TestMethod]
        public void TestFireDrill()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[]{0,0,0,0}, // 1
                new int[]{0,0,0,0}, // 2
                new int[]{0,0,0,0}, // 3
                new int[]{0,0,0,0}, // 4
                new int[]{0,0,0,0}, // 5
                new int[]{0,0,0,0}, // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 6, 5, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 0, 4, 3, 2, 1, 0, 3, 2, 1, 0, 1, 0 }, result);
        }

        [TestMethod]
        public void RandomTest()
        {
            //Random test #0: floors=20, people=42, capacity=4
            int[][] queues =
            {
                new int[]{13,16,18,8}, // G
                new int[]{5}, // 1
                new int[0], // 2
                new int[]{6,16,19}, // 3
                new int[]{9,5,14,7}, // 4
                new int[]{15,0,8,13}, // 5
                new int[]{8,8,11}, // 6
                new int[0], // 7
                new int[0], // 8
                new int[]{0,16,19,13}, // 9
                new int[]{5,1,14}, // 10
                new int[]{1}, // 11
                new int[0], // 12
                new int[]{13,18}, // 13
                new int[]{4,6,15,13}, // 14
                new int[]{5,17,0}, // 15
                new int[0], // 16
                new int[]{10,0,2,12}, // 17
                new int[]{16,3}, // 17
                new int[0], // 19
            };
            var result = TheLiftClass.TheLift(queues, 4);
            CollectionAssert.AreEqual(new[] { 0, 1, 3, 4, 5, 6, 8, 9, 10, 13, 14, 15, 16, 18, 17, 16, 15, 14, 13, 11, 10, 9, 5, 3, 1, 0, 1, 3, 4, 5, 6, 8, 9, 10, 13, 14, 15, 16, 17, 19, 17, 15, 14, 12, 10, 9, 2, 1, 0, 4, 5, 6, 7, 8, 9, 10, 13, 14, 15, 18, 14, 13, 9, 6, 4, 0, 5, 6, 8, 11, 13, 0 }, result);
        }

        [TestMethod]
        public void TestHighlander()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[]{2}, // 1
                new int[]{3,3,3}, // 2
                new int[]{1}, // 3
                new int[0], // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 1);
            CollectionAssert.AreEqual(new[] { 0, 1, 2, 3, 1, 2, 3, 2, 3, 0 }, result);
        }

        [TestMethod]
        public void TestLiftFullDown()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[0], // 1
                new int[0], // 2
                new int[]{1,1,1,1,1,1,1,1,1,1,1}, // 3
                new int[0], // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 3, 1, 3, 1, 3, 1, 0 }, result);
        }

        [TestMethod]
        public void TestLiftFullUp()
        {
            int[][] queues =
            {
                new int[]{3,3,3,3,3,3}, // G
                new int[0], // 1
                new int[0], // 2
                new int[0], // 3
                new int[0], // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 3, 0, 3, 0 }, result);
        }

        [TestMethod]
        public void TestLiftFullUpAndDown()
        {
            int[][] queues =
            {
                new int[]{3,3,3,3,3,3}, // G
                new int[0], // 1
                new int[0], // 2
                new int[0], // 3
                new int[0], // 4
                new int[]{4,4,4,4,4,4}, // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 3, 5, 4, 0, 3, 5, 4, 0 }, result);
        }

        [TestMethod]
        public void TestTrickyQueues()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[]{0,0,0,6}, // 1
                new int[0], // 2
                new int[0], // 3
                new int[0], // 4
                new int[]{6,6,0,0,0,6}, // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 5);
            CollectionAssert.AreEqual(new[] { 0, 1, 5, 6, 5, 1, 0, 1, 0 }, result);
        }

        [TestMethod]
        public void TestYoYo()
        {
            int[][] queues =
            {
                new int[0], // G
                new int[0], // 1
                new int[]{4,4,4,4}, // 2
                new int[0], // 3
                new int[]{2,2,2,2}, // 4
                new int[0], // 5
                new int[0], // 6
            };
            var result = TheLiftClass.TheLift(queues, 2);
            CollectionAssert.AreEqual(new[] { 0, 2, 4, 2, 4, 2, 0 }, result);
        }
    }
}
