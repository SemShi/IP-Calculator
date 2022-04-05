namespace IP_Calculate
{
    internal class IP_Enter
    {
        public int firstPartIP;
        public int secondPartIP;
        public int thirdPartIP;
        public int fourthPartIP;

        public bool IP_Check()
        {
            if (IP_EnterCheck(firstPartIP, secondPartIP, thirdPartIP, fourthPartIP)) { return true; }
            else { return false; }
        }

        private bool IP_EnterCheck(in int firstPartIP, int secondPartIP, int thirdPartIP, int fourthPartIP)
        {
            void Msg(int oktet)
            {
                if(oktet == 1) { MessageBox.Show($"{oktet}-st oktet has the wrong value!", "Error!"); }
                else if (oktet == 2) { MessageBox.Show($"{oktet}-nd oktet has the wrong value!", "Error!"); }
                else { MessageBox.Show($"{oktet}-th oktet has the wrong value!", "Error!"); }
            }
            int oktet = 0;
            string num1 = firstPartIP.ToString();
            string num2 = secondPartIP.ToString();
            string num3 = thirdPartIP.ToString();
            string num4 = fourthPartIP.ToString();
            bool process = true;
            while (process)
            {
                if (firstPartIP > 255) { Msg(oktet = 1); return false; }
                if (secondPartIP > 255) { Msg(oktet = 2); return false; }
                if (thirdPartIP > 255) { Msg(oktet = 3); return false; }
                if (fourthPartIP > 255) { Msg(oktet = 4); return false; }
                process = false;
            }
            return true;
        }
    }
}