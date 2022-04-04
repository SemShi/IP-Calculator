namespace IP_Calculate
{
    internal class startCalculate
    {
        private int[] binaryArray = new int[8];
        public string nw = "";
        public string bc = "";
        public string hsts = "";

        public void Calculating(int mask, int partIP1, int partIP2, int partIP3, int partIP4)
        {
            int step = 0;
            int zerosInIP = 32 - mask;
            int zerosInOctet;
            int hosts;
            int res = 0;

            if (mask < 9)
            {
                zerosInOctet = zerosInIP % 24;
                partIP2 = 0;
                partIP3 = 0;
                partIP4 = 0;

                for (int i = 0; i < zerosInOctet; i++)
                {
                    step += Convert.ToInt32(Math.Pow(2, i));
                }
                while (res <= partIP1)
                {
                    res += step;
                    if (res < partIP1) { res++; }
                }
                if (step == 0) { res--; }
                res -= step;
                partIP1 = res;
                if (partIP1 < 0) { partIP1 = 0; }
                if(mask == 1) 
                {
                    hosts = int.MaxValue - 1;
                    nw = $"{partIP1}.{partIP2}.{partIP3}.{partIP4}";
                    bc = $"{partIP1 + step}.{partIP2 = 255}.{partIP3 = 255}.{partIP4 = 255}";
                    hsts = $"{hosts} | всего: 2147483648";
                    if (hsts == "-2" || hsts == "-1") { hsts = "0"; }
                }
                else if(mask == 0)
                {
                    nw = $"{partIP1}.{partIP2}.{partIP3}.{partIP4}";
                    bc = $"{partIP1 = 255}.{partIP2 = 255}.{partIP3 = 255}.{partIP4 = 255}";
                    hsts = $"4294967294 | всего: 4294967296";
                }
                else
                {
                    hosts = Convert.ToInt32(Math.Pow(2, zerosInIP)); if (hosts < 0) { hosts = 0; }
                    nw = $"{partIP1}.{partIP2}.{partIP3}.{partIP4}";
                    bc = $"{partIP1 + step}.{partIP2 = 255}.{partIP3 = 255}.{partIP4 = 255}";
                    hsts = $"{hosts - 2} | всего: {hosts}";
                }
            }
            else if (mask < 17)
            {
                zerosInOctet = zerosInIP % 16;
                partIP3 = 0;
                partIP4 = 0;

                for (int i = 0; i < zerosInOctet; i++)
                {
                    step += Convert.ToInt32(Math.Pow(2, i));
                }
                while (res <= partIP2)
                {
                    res += step;
                    if (res < partIP2) { res++; }
                }
                if (step == 0) { res--; }
                res -= step;
                partIP2 = res;
                if (partIP2 < 0) { partIP2 = 0; }
                hosts = Convert.ToInt32(Math.Pow(2, zerosInIP)); if (hosts < 0) { hosts = 0; }
                nw = $"{partIP1}.{partIP2}.{partIP3}.{partIP4}";
                bc = $"{partIP1}.{partIP2 + step}.{partIP3 = 255}.{partIP4 = 255}";
                hsts = $"{hosts - 2} | всего: {hosts}";
            }
            else if (mask < 25)
            {
                zerosInOctet = zerosInIP % 8;
                partIP4 = 0;
                
                for (int i = 0; i < zerosInOctet; i++)
                {
                    step += Convert.ToInt32(Math.Pow(2, i));
                }
                while (res <= partIP3)
                {
                    res += step;
                    if(res < partIP3) { res++; }
                }
                if(step == 0) { res--; }
                res -= step;
                partIP3 = res;
                if (partIP3 < 0) { partIP3 = 0; }
                hosts = Convert.ToInt32(Math.Pow(2, zerosInIP)); if (hosts < 0) { hosts = 0; }
                nw = $"{partIP1}.{partIP2}.{partIP3}.{partIP4}";
                bc = $"{partIP1}.{partIP2}.{partIP3 + step}.{partIP4 = 255}";
                hsts = $"{hosts - 2} | всего: {hosts}";
            }
            else
            {
                zerosInOctet = zerosInIP;
                hosts = Convert.ToInt32(Math.Pow(2, zerosInIP)); if (hosts < 0) { hosts = 0; }
                for (int i = 0; i < zerosInOctet; i++)
                {
                    step += Convert.ToInt32(Math.Pow(2, i));
                }
                partIP4 = networkOctet(partIP4, hosts);
                if (partIP4 < 0) { partIP4 = 0; }

                nw = $"{partIP1}.{partIP2}.{partIP3}.{partIP4}";
                bc = $"{partIP1}.{partIP2}.{partIP3}.{partIP4 + step}";
                hsts = $"{hosts - 2}  | всего: {hosts}";
                if (hosts <= 1) { hsts = "0"; }
            }
        }
        private int networkOctet(int partIP, int hosts)
        {
            int temp = 0;
            int result = 0;
            binaryArray[0] = 1;
            binaryArray[1] = 2;
            binaryArray[2] = 4;
            binaryArray[3] = 8;
            binaryArray[4] = 16;
            binaryArray[5] = 32;
            binaryArray[6] = 64;
            binaryArray[7] = 128;

            for (int i = 7; i >= 0; i--)
            {
                if (binaryArray[i] < partIP)
                {
                    temp = binaryArray[i];
                    break;
                }
            }

            int temp2 = 0;
            if (temp % hosts == 0) { temp2 = temp; result = temp2; }
            for (int i = 0; i < binaryArray.Length - 1; i++)
            {
                if (temp + binaryArray[i + 1] > partIP) { continue; }
                if (temp + binaryArray[i + 1] > temp2 && temp + binaryArray[i + 1] < partIP && (temp + binaryArray[i + 1]) % hosts == 0)
                { temp = temp + binaryArray[i + 1]; result = temp; }
            }
            return result;
        }
    }
}