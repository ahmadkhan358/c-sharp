using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicalAnalyzer
{
    class Node
    {
        private string lexeme;
        private string token;
        private Node next;

        public Node(string l, string t)
        {
            lexeme = l;
            token = t;
            next = null;
        }

        public string getLexeme()
        {
            return lexeme;
        }


        public string getToken()
        {
            return token;
        }

        public Node getNext()
        {
            return next;
        }

        public void setLexeme(string l)
        {
            lexeme = l;
        }


        public void setToken(string t)
        {
            token = t;
        }

        public void setNext(Node n)
        {
            next = n;
        }
    }
}
