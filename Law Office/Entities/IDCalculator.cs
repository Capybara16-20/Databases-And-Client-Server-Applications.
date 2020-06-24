using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public static class IDCalculator
    {
        public static int GetID()
        {
            Guid guid = Guid.NewGuid();
            string strGuid = guid.ToString().Replace("-", "");
            StringBuilder sb = new StringBuilder();
            int count = 0;
            while (sb.Length < 6)
            {
                if (char.IsDigit(strGuid[count]))
                {
                    sb.Append(strGuid[count]);
                }
                count++;
            }
            return Int32.Parse(sb.ToString());
        }
    }
}
