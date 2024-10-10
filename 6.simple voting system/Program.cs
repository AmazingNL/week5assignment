namespace _6.simple_voting_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
           program.Start();
        }
        void Start()
        {
            Console.WriteLine("How many votes should be processed: ");
            int size = int.Parse(Console.ReadLine());

            VotingSystem voting = new VotingSystem(size);

            for (int i = 0; i < size; i++) {
                Console.Write("Enter your vote (Yes/No): ");
                string vote = Console.ReadLine().ToUpper();
                Console.WriteLine($"Vote casted {vote}");

                if (vote == "YES")
                {
                    voting.CastVote(VoteOption.Yes);
                }
                else
                {
                    voting.CastVote(VoteOption.No);
                }
            }
            voting.DisplayResults();

        }
    }
}
