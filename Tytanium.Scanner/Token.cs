﻿namespace Tytanium.Scanner
{
    public class Token
    {
        public string Literal;
        public Refrence.Class Type;
        public Refrence.UpperClass UpperType;
        public int Line;

        public Token(string str, Refrence.UpperClass UC)
        {
            Literal = str;
            UpperType = UC;
        }

        public Token(string str, Refrence.UpperClass UC, Refrence.Class C)
        {
            Literal = str;
            Type = C;
            UpperType = UC;
        }

        public Token(string str, Refrence.UpperClass UC, Refrence.Class C,int L)
        {
            Line = L;
            Literal = str;
            Type = C;
            UpperType = UC;
        }
    }
}
