using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmetods2
{
    class stringmetods2
    {
        public string Str;
        public string Data;
       
        public int GetLength()
        {
            int count = 0;
            foreach (char f in Str)
            {
                count++;

            }
            return count;
        }

        public string Substring(int fromIndex, int count)
        {
            int total = fromIndex + count;
            string result = "";
            for (int i = fromIndex; i <total; i++)
            {
                result += Str[i];
            }
            return result;
        }

        public int indexOf(string phrase)
        {
            int index = -1;

            int main = Str.Length - phrase.Length;
            for (int a = 0; a <= main; a++)
            {
                string result = Substring(a, phrase.Length);

                if (result == phrase)
                {
                    index = a;
                    break;
                }
            }
            return index;
        }

        public bool Contains(string phrase)
        {
            bool isFind = false;

            int main = Str.Length - phrase.Length;
            for (int a = 0; a <= Str.Length; a++)
            {
                string result = Substring(a, phrase.Length);

                if (result == phrase)
                {
                    isFind = true;
                    break;
                }
            }
            return isFind;
        }

        public string Insert(int index,string phrase)
        {
            string left = Substring(0, index);
            string rigth = Substring(index ,Str.Length-index);
            return $"{left} {phrase} {rigth}";

        }

        public string RemoveChar(int fromindex)
        {
            string left = Substring(0, fromindex);
          
            return $"{left} ";
        }

        public string Remove(int fromindex,int count)
        {
            string left = Substring(0, fromindex);
            int to = fromindex + count;
            string rigth = Substring(to,Str.Length-to);
            return $"{left}  {rigth}";
        }

        public string Padleft(int total, char symbol)
        {
            int strlength = Str.Length;

            int esp = total - strlength;
            string box = String.Empty;
            for(int i = 0; i <esp;i++)
            {
                box += symbol;
            }
           return $"{box} {Str}";
        }

        public string PadRight(int total, char symbol)
        {
            int strlength = Str.Length;

            int esp = total - strlength;
            string box = String.Empty;
            for (int i = 0; i < esp; i++)
            {
                box += symbol;
            }
            return $"{Str}{box} ";
        }

        public bool StartWith(string phrase)
        {
            bool isFind = false;
           
                string check = Substring(0, phrase.Length);
                if (check == phrase)
                {
                    return isFind = true;
                }

            return isFind;
        }

        public bool EndsWith(string phrase)
        {
            bool isFind = false;

            for(int i = Str.Length-phrase.Length; i >= 0; i--)
            {
                string check = Substring(i,phrase.Length);
                
                if (check == phrase)
                {
                     isFind = true;
                }
               
            }
               

            return isFind;
        }
        public string Replace(string oldStr,string Strnew)
        {
            int leftIndex = indexOf(oldStr);
            string left = Substring(0, leftIndex);

            int count = leftIndex + oldStr.Length;
            string rigth = Substring(count, Str.Length-count);
            return $"{left} {Strnew} {rigth}";
        }

        public int LastIndexOf(string symbol)
        {
            int index = -1;
            for (int a = Data.Length - 1; a >= 0; a--)
            {
                string value = Substring(a, symbol.Length);
                if (value == symbol)
                {
                    index = a;
                    break;
                }
            }
            return index;
        }

        //public int FirstIndexOf(string symbol)
        //{
        //    int index = -1;
        //    for (int a = 0; a <= Str.Length - 1; a++)
        //    {
        //        string value = Substring(a, symbol.Length);
        //        if (value == symbol)
        //        {
        //            index += a;
                   
        //            break;
        //        }
        //    }
        //    return index;
        //}
        //public string TrimEnds(char symbol)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    int count = 0;
            
        //    for(int i = Data.Length - 1; i >= 0; i--)
        //    {
        //        if (symbol == Data[i])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            break;
        //        }
               
        //    }
        //    string result = Data.Substring(0,Data.Length - count);
        //    return result.ToString();
        //}

        //public string TrimStart(char symbol)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();

        //    int count = 0;
        //    int length = Data.Length;

        //    for(int i = 0; i < length; i++)
        //    {
        //        if (Data[i] == symbol)
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    string result = Data.Substring(count, Data.Length - count);
        //    return result.ToString();

        //}

        public string Trim(char symbol)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count1 = 0;
            int count2 = 0;
            int length = Data.Length;
            for(int i = 0; i<=length - 1; i++)
            {
                if (Data[i] == symbol)
                {
                    count1++;
                }
                else
                {
                    break;
                } 
            }
           
            for(int k = length-1; k >= 0; k--)
            {
                if (Data[k] == symbol)
                {
                    count2++;
                }
                else
                {
                    break;
                }
            }
            string result = Data.Substring(count1,Data.Length-(count2+count1));
            return $"{result}";
        }

    }
}
