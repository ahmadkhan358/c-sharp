using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicalAnalyzer
{
   
    class Scanner
    {
        private string input;
        private List<LexToken> LexTokensList;
        private string funcKeyWord;
        private string leftParan;
        private string rightParan;
        private string funcName;
        private string varName;
        private string leftBrace;
        private string rightBrace;
        private string addOp;
        private string mulOp;
        private string semiColon;
        private SymbolTable table;


        public Scanner(string i)
        {
            
            input = i;
            funcKeyWord = "function";
            leftParan = "(";
            rightParan = ")";
            funcName = "sum";
            varName = "num";
            leftBrace = "{";
            rightBrace = "}";
            addOp = "+";
            mulOp = "*";
            semiColon = ";";
            LexTokensList = new List<LexToken>();

            table = new SymbolTable(50);
            table.insert(funcKeyWord, "keyword");
            table.insert(leftParan, "operator");
            table.insert(rightParan, "operator");
            table.insert(leftBrace, "operator");
            table.insert(rightBrace, "operator");
            table.insert(funcName, "identifier");
            table.insert(varName, "identifier");
            table.insert(addOp, "arithematic operator");
            table.insert(mulOp, "arithematic operator");
            table.insert(semiColon, "terminator");
        }

       
        

        public List<LexToken> getLexTokens()
        {
            return LexTokensList;
        }



        public void lexAnalyzerInAction()
        {
            //input = inputPreprocessing();
            bool comment = false;
            string m = "";
            int length = input.Length;
            char ch;

            for (int i=0; i<length; i++)
            {
                ch = input[i];

                if (comment)
                {
                    if(ch == '\n')
                    {
                        comment = false;
                    }
                }
                else
                {
                    if (ch == '/')
                    {
                        if (input[i + 1] == '/')
                        {
                            comment = true;
                        }
                    }
                    if(ch != '\n' || ch == ' ' || !comment)
                    {
                        m += ch;
                        

                        if (m == "\n" || m == " " || m == "/")
                        {
                            m = "";
                        }
                        

                        if (m == addOp || m == mulOp)
                        {
                            LexToken newLexToken = new LexToken();
                            newLexToken.Lexeme = m;
                            newLexToken.Token = "arithematic operator";
                            table.insert(m, "arithematic operator");
                            LexTokensList.Add(newLexToken);
                            m = "";
                        }

                        if(m == leftParan || m == rightParan || m == leftBrace || m == rightBrace)
                        {
                            LexToken newLexToken = new LexToken();
                            newLexToken.Lexeme = m;
                            newLexToken.Token = "operator";
                            table.insert(m, "operator");
                            LexTokensList.Add(newLexToken);
                            m = "";
                        }

                        if(m == varName || m == funcName)
                        {
                            LexToken newLexToken = new LexToken();
                            newLexToken.Lexeme = m;
                            newLexToken.Token = "identifier";
                            table.insert(m, "identifier");
                            LexTokensList.Add(newLexToken);
                            m = "";
                        }

                        if (m == semiColon)
                        {
                            LexToken newLexToken = new LexToken();
                            newLexToken.Lexeme = m;
                            newLexToken.Token = "terminator";
                            table.insert(m, "terminator");
                            LexTokensList.Add(newLexToken);
                            m = "";
                        }

                        if (m == funcKeyWord)
                        {
                            LexToken newLexToken = new LexToken();
                            newLexToken.Lexeme = m;
                            newLexToken.Token = "keyword";
                            table.insert(m, "keyword");
                            LexTokensList.Add(newLexToken);
                            m = "";
                        }
                    }
                }
            }
        }

    }
}

