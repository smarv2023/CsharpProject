namespace Testing
{
    public static class TestProgram
    {
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class TestingProgram
    {
        private int i;
        public int I
        {
            set { i = value; }
            get { return i; }
        }
        public TestingProgram(int i)
        {
            I = i;
        }
    }
}