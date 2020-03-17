namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                m_score1 += 1;
            if (playerName == player2Name)
                m_score2 += 1;
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
            string score = "";

            if (m_score1 >= 4 || m_score2 >= 4)
            {
                if (System.Math.Abs(m_score1 - m_score2) == 1)
                    score = "Advantage ";
                else
                    score = "Win for ";
                if (m_score1 > m_score2)
                    return score + player1Name;
                if (m_score1 < m_score2)
                    return score + player2Name;
            }

            score += GetScoreDescribtion(m_score1) + "-";
    
            if (m_score1 != m_score2)
                return score + GetScoreDescribtion(m_score2);

            if (m_score1 < 3)
                return score + "All";

            return "Deuce";
        }
    }
}

