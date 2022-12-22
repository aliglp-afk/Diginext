using System;
using System.Text;

namespace Digi
{
    internal class Program
    {
        public static int QuestionOne(string text,int count){
            
            int result = 0;
            int i =0;
            string p="";

            while(i<=count){

                for (int j = 0; j < text.Length; j++)
                {
                    if(i<=count){
                        p+=text[j];
                    }
                    i++; 
                }
            }

            p.ToList().ForEach(f=>{
                
                if(f==text[0])
                {
                    result++;
                }
            });

            return result;
        }
        public static int QuestionTwo(string text){
            
            int result=0;
            StringBuilder s = new StringBuilder(text);
            for(int i =1;i<s.Length;i++){
                if(i-1>-1){
                    if(s[i]==s[i-1]){

                        s.Remove(i,1);
                        i--;
                        result++;
                    }
                }
            }
            return result;

        }        
        public static int QuestionThree(int[] nums){
            
            int len = nums.Length;
            Dictionary<int, int> map
                = new Dictionary<int, int>();

            for (int i = 0; i < len; i++)
                map.Add(nums[i], i);

            Array.Sort(nums);

            bool[] visited = new bool[len];

            int ans = 0;
            for (int i = 0; i < len; i++) {

                if (visited[i] || map[nums[i]] == i)
                    continue;

                int j = i, cycle_size = 0;
                while (!visited[j]) {
                    visited[j] = true;

                    j = map[nums[j]];
                    cycle_size++;
                }
                if (cycle_size > 0) {
                    ans += (cycle_size - 1);
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            #region Question One 
            
            // Console.WriteLine($"{QuestionOne("abcac",10)}");
            // Console.WriteLine($"{QuestionOne("aba",10)}");

            #endregion
            
            #region Question Two 
            
            // Console.WriteLine($"{QuestionTwo("AABAAB")}");
            // Console.WriteLine($"{QuestionTwo("AAA")}");
            // Console.WriteLine($"{QuestionTwo("BBBBB")}");
            // Console.WriteLine($"{QuestionTwo("ABABABAB")}");
            // Console.WriteLine($"{QuestionTwo("BABABA")}");
            // Console.WriteLine($"{QuestionTwo("BABABA")}");
            // Console.WriteLine($"{QuestionTwo("AAABBB")}");

            #endregion
            
            #region Question Three 
            
            int[] Numbers=new int[]{
                7,1,3,2,4,5,6
            };
            
            // Console.WriteLine($"{QuestionThree(Numbers)}");
            #endregion
        }
    }
}