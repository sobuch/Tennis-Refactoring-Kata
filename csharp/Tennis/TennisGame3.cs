namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int player1Score;
        private int player2Score;
        private string player1Name;
        private string player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            string s;
            if (player1Score < 4 && player2Score < 4 && !(player1Score == 3 && player2Score == 3))
            {
                string[] scores = { "Love", "Fifteen", "Thirty", "Forty" };
                s = scores[player1Score];
                return (player1Score == player2Score) ? s + "-All" : s + "-" + scores[player2Score];
            }
            if (player1Score == player2Score)
                return "Deuce";
            s = player1Score > player2Score ? player1Name : player2Name;
            return (System.Math.Abs(player1Score - player2Score) >= 2) ? "Win for " + s : "Advantage " + s;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                player1Score += 1;
            if (playerName == player2Name)
                player2Score += 1;
        }

    }
}

