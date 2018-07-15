using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonNames = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            char[] damageChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', '.' };
            foreach (var demonName in demonNames.OrderBy(n => n))
            {
                string name = demonName.Trim();
                double demonHealth = 0;
                double demonDamage = 0;
                double currentDamage = 0;
                string textForDamage = "0";
                int devideCount = 0;
                int multiplyCount = 0;
                StringBuilder sb = new StringBuilder();
                foreach (var character in name)
                {
                    if (damageChars.Contains(character))
                    {
                        if (character == '/')
                        {
                            devideCount++;
                        }
                        else if (character == '*')
                        {
                            multiplyCount++;
                        }
                        else
                        {
                            textForDamage = sb.Append(character).ToString();
                        }

                    }
                    else
                    {
                        demonHealth += character;
                        currentDamage = double.Parse(textForDamage);
                        demonDamage += currentDamage;
                        currentDamage = 0;
                        textForDamage = "0";
                        sb.Clear();
                    }
                }
                demonDamage += double.Parse(textForDamage);
                while (multiplyCount-- > 0)
                {
                    demonDamage *= 2;
                }
                while (devideCount-- > 0)
                {
                    demonDamage /= 2;
                }
                Console.WriteLine($"{name} - {demonHealth} health, {demonDamage:f2} damage");
            }
        }
    }
}
