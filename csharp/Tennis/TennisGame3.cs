namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int p1;
        private int p2;
        private string p1N;
        private string p2N;

        public TennisGame3(string player1Name, string player2Name)
        {
            p1N = player1Name;
            p2N = player2Name;
        }

        public string GetScore()
        {
            string s;
            if (p1 < 4 && p2 < 4 && !(p1 == 3 && p2 == 3))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[p1];
                return (p1 == p2) ? s + "-All" : s + "-" + p[p2];
            }
            if (p1 == p2)
                return "Deuce";
            s = p1 > p2 ? p1N : p2N;
            return (System.Math.Abs(p1 - p2) == 1) ? "Advantage " + s : "Win for " + s;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == p1N)
                p1 += 1;
            if (playerName == p2N)
                p2 += 1;
        }

    }
}

