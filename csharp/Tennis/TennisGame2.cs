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

        public string GetScore()
        {
            string p1res = "";
            string p2res = "";
            string score = "";

            if (p1point == p2point && p1point < 3)
            {
                if (p1point == 0)
                    score = "Love";
                if (p1point == 1)
                    score = "Fifteen";
                if (p1point == 2)
                    score = "Thirty";
                return score + "-All";
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

            if (p1point == 0)
                p1res = "Love";
            if (p1point == 1)
                p1res = "Fifteen";
            if (p1point == 2)
                p1res = "Thirty";
            if (p1point == 3)
                p1res = "Forty";

            if (p2point == 0)
                p2res = "Love";
            if (p2point == 1)
                p2res = "Fifteen";
            if (p2point == 2)
                p2res = "Thirty";
            if (p2point == 3)
                p2res = "Forty";

            return score = p1res + "-" + p2res;
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

