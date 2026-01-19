namespace FitnessLeaderboard
{
    interface ILeaderboard
    {
        void AddUser(string name, int steps);
        void UpdateSteps(string name, int steps);
        void Display();
    }
}
