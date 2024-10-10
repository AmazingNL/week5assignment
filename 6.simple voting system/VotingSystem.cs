
namespace _6.simple_voting_system
{
    internal class VotingSystem
    {
        private VoteOption[] votes;
        private int index;
        public VotingSystem(int size) {
            votes = new VoteOption[size];
            index = 0;
        }
        public void CastVote(VoteOption vote)
        {
            if (index < votes.Length) {
                votes[index] = vote;
                index++;
                Console.WriteLine($"Voste casted {votes}");
            }
        }
        public void DisplayResults()
        {
            int yes = 0;
            int no = 0;
            for (int i = 0; i < index; i++)
            {
                if (votes[i] == VoteOption.Yes)
                {
                    yes++;
                }
                else
                {
                    no++;
                }
            }
            Console.WriteLine($"Number of yes casted: {yes}");
            Console.WriteLine($"Number of No casted: {no}");

        }

    }
}
