using System.Text.RegularExpressions;

namespace CodeWars._6_kyu;

/*
Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
Valid inputs examples:

Examples of valid inputs:
1.2.3.4
123.45.67.89

Invalid input examples:

1.2.3
1.2.3.4.5
123.456.78.90
123.045.067.089

Notes:
    Leading zeros (e.g. 01.02.03.04) are considered invalid
    Inputs are guaranteed to be a single string

*/

public static class IPValidation
{
    public static bool IsValidIp(string ipAddress)
    {
        if (String.IsNullOrEmpty(ipAddress))
            return false;
        
        var octets = ipAddress.Split('.');
        int octetCount = octets.Length;
        
        if (octetCount != 4) return false;
        if (ipAddress.Any(Char.IsWhiteSpace)) return false;

        foreach (var octet in octets)
        {
            if(int.TryParse(octet, out int numberOctet))
            {
                if (numberOctet < 0 || numberOctet > 255) return false;
            }
            else
            {
                return false;
            }

            if (octet.Length >= 2)
            {
                if (octet[0] == '0') return false;
            }
        }
        
        

        return true;
    }
}