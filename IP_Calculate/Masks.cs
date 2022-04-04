namespace IP_Calculate
{
    internal class Masks
    {
        public string currentMask = "";
        string[] masks = new string[33];
        public void enterMask(int mask)
        {
            masks[0] = "0.0.0.0";
            masks[1] = "128.0.0.0";
            masks[2] = "192.0.0.0";
            masks[3] = "224.0.0.0";
            masks[4] = "240.0.0.0";
            masks[5] = "248.0.0.0";
            masks[6] = "252.0.0.0";
            masks[7] = "254.0.0.0";
            masks[8] = "255.0.0.0";
            masks[9] = "255.128.0.0";
            masks[10] = "255.192.0.0";
            masks[11] = "255.224.0.0";
            masks[12] = "255.240.0.0";
            masks[13] = "255.248.0.0";
            masks[14] = "255.252.0.0";
            masks[15] = "255.254.0.0";
            masks[16] = "255.255.0.0";
            masks[17] = "255.255.128.0";
            masks[18] = "255.255.192.0";
            masks[19] = "255.255.224.0";
            masks[20] = "255.255.240.0";
            masks[21] = "255.255.248.0";
            masks[22] = "255.255.252.0";
            masks[23] = "255.255.254.0";
            masks[24] = "255.255.255.0";
            masks[25] = "255.255.255.128";
            masks[26] = "255.255.255.192";
            masks[27] = "255.255.255.224";
            masks[28] = "255.255.255.240";
            masks[29] = "255.255.255.248";
            masks[30] = "255.255.255.252";
            masks[31] = "255.255.255.254";
            masks[32] = "255.255.255.255";

            currentMask = masks[mask];
        }
    }
}
