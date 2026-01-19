namespace FitnessLeaderboard
{
    class Node
    {
        public string UserName;
        public int Steps;
        public Node Next;

        public Node(string name, int steps)
        {
            UserName = name;
            Steps = steps;
            Next = null;
        }
    }
}
