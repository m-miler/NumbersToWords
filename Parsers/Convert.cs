using Parsers.Countries;

namespace Parsers
{
    public class Convert: IWords
    {
        public virtual List<List<string>> Small { get; }
        public virtual List<string> Midium { get; }
        public virtual List<List<string>> Big { get; }


        public string ConvertNumberToString(double value) 
        {
            double rounded_amount = Math.Round(value, 2); 
            double amount = Math.Floor(rounded_amount); 
            string amount_as_str = amount.ToString();
            string coverted_amount = "";
            List<List<int>> split = new List<List<int>>();
            split.Add(new List<int> {-1, -1, -1 });

            int i = 0;
            int g = 0;


            for (int pos = amount_as_str.Length -1; pos >= 0; pos--) 
            {
                split[g][i] = Int32.Parse(amount_as_str[pos].ToString());
                if (i == 2 & pos > 0) 
                {
                    g++;
                    i = -1;
                    split.Add(new List<int> { -1, -1, -1 });
                }
                i++;
            }


            for (i = 0; i != split.Count; i++)
            {
                string temp = "";
                for (int j = 2; j >= 0; j--) 
                {
                    if ( j == 1) 
                    {
                        if (split[i][j] == 1) 
                        {
                            temp = $"{temp}{Midium[split[i][0]]} ";
                        }
                        else 
                        {
                            if (split[i][j] > 0) 
                            {
                                temp = $"{temp}{Small[j][split[i][j]]} ";
                            }
                        }
                    }
                    else 
                    {
                        if (split[i][j] > 0) 
                        {
                            temp = $"{temp}{Small[j][split[i][j]]} ";
                        }
                    }
                }

                if (split[i][2] > -1)
                {
                    if (i + 1 <= g)
                    {
                        int rest;
                        switch (split[i + 1][0])
                        {
                            case 1: rest = 0; break;
                            case 2: rest = 1; break;
                            case 3: rest = 1; break;
                            case 4: rest = 1;break;
                            default: rest = 2; break;
                        }
                        if (split[i + 1][1] == 1)
                        {
                            rest = 2;
                        }
                        if (split[i + 1][0] > 0 | split[i + 1][1] > 0 | split[i + 1][2] > 0)
                        {
                            coverted_amount = $"{Big[i][rest]} {temp}{coverted_amount}";
                        }
                        else 
                        {
                            coverted_amount = $"{temp}{coverted_amount}";
                        }

                    }
                    else 
                    {
                        coverted_amount = $"{temp}{coverted_amount}";
                    }
                }
                else 
                {
                    coverted_amount = $"{temp}{coverted_amount}";
                }
            }

            return coverted_amount.TrimEnd();
        }
    }
}