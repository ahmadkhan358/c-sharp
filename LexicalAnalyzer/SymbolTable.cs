using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicalAnalyzer
{
    class SymbolTable
    {
        private static int size;
        private Node[] table;

        public SymbolTable(int s)
        {
            size = s;
            table = new Node[s];
            for(int i=0; i<s; i++)
            {
                table[i] = null;
            }
        }

        public int _hash(string lexeme)
        {
            int sum = 0;
            foreach(char ch in lexeme)
            {
                int c = (int)ch;
                sum += c;
            }

            sum *= 9;
            sum %= size;
            return sum;
        }

        public void insert(string l, string t)
        {
            if (!lookup(l))
            {
                int index = _hash(l);
                Node node = new Node(l, t);

                if(table[index] == null)
                {
                    table[index] = node;
                }
                else
                {
                    Node container = table[index];
                    while(container.getNext() != null)
                    {
                        container = container.getNext();
                    }
                    container.setNext(node);
                }
            }
        }


        public bool lookup(string l)
        {
            int index = _hash(l);

            if (table[index] != null)
            {
                Node container = table[index];
                while (true)
                {
                    if(container == null)
                    {
                        return false;
                    }

                    if (l.Equals(container.getLexeme()))
                        break;
                    container = container.getNext();
                }
                return true;
            }
            else
                return false;
        }

        public Node get(string l)
        {
            return table[_hash(l)];
        }

    }
}
