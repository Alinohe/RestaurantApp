namespace RestaurantApp
{
    public class Tests
    {
        [Test]
        public void WhenPushItems_CorrectPopValue_double()
        {
            var stack = new Stack<double>();
            stack.Push(item: 1.2);
            stack.Push(item: 1.6);
            stack.Push(item: 3.7);
            stack.Push(item: 4.2);

            var popValue = stack.Pop();

            Assert.That(popValue, Is.EqualTo(4.2));
        }

        [Test]
        public void WhenPushItems_CorrectPopSumValue_double()
        {
            var stack = new Stack<double>();
            stack.Push(item: 1.2);
            stack.Push(item: 1.6);
            stack.Push(item: 3.7);
            stack.Push(item: 4.2);

            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                sum += item;
            }

            Assert.AreEqual(10.7, sum);
        }

        [Test]
        public void WhenPushItems_CorrectPopValue_string()
        {
            var stack = new Stack<string>();
            stack.Push(item: "A");
            stack.Push(item: "B");
            stack.Push(item: "C");
            stack.Push(item: "D");

            var popValue = stack.Pop();

            Assert.That(popValue, Is.EqualTo("D"));
        }
    }
}
