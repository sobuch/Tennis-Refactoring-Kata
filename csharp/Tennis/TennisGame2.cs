namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int p1point = 0;
        private int p2point = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        private static string GetScoreDescribtion(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                default:
                    return "Forty";
            }
        }

        public string GetScore()
        {
            if (p1point == p2point && p1point < 3)
            {
                return GetScoreDescribtion(p1point) + "-All";
            }

            if (p1point == p2point)
                return "Deuce";

            if (p1point >= 4 && p2point >= 0 && (p1point - p2point) >= 2)
            {
                return "Win for " + player1Name;
            }
            if (p2point >= 4 && p1point >= 0 && (p2point - p1point) >= 2)
            {
                return "Win for " + player2Name;
            }

            if (p1point > p2point && p2point >= 3)
            {
                return "Advantage " + player1Name;
            }
            if (p2point > p1point && p1point >= 3)
            {
                return "Advantage " + player2Name;
            }

            return GetScoreDescribtion(p1point) + "-" + GetScoreDescribtion(p2point);
        }

        private void P1Score()
        {
            p1point++;
        }

        private void P2Score()
        {
            p2point++;
        }

        public void WonPoint(string player)
        {
            if (player == player1Name)
                P1Score();
            if (player == player2Name)
                P2Score();
        }
    }
}

