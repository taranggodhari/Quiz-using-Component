using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Quiz
{
    class Answers
    {
        private string answers1, answers2;
        private string useranswer1, useranswer2;
        public string Answer1
        {
            get { return answers1; }
            set { answers1 = value; }
        }
        public string Answer2
        {
            get { return answers2; }
            set { answers2 = value; }
        }
        public string UserAnswer1
        {
            get { return useranswer1; }
            set { useranswer1 = value; }
        }
        public string UserAnswer2
        {
            get { return useranswer2; }
            set { useranswer2 = value; }
        }


    }
}
