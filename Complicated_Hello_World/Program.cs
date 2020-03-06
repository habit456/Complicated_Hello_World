using System;

namespace User
{
    class Program
    {
        static void Main()
        {
            Alphabet upperCase = new Alphabet('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
            Alphabet lowerCase = new Alphabet('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z');

            Character upperH = new Character(upperCase.H);
            Character lowerE = new Character(lowerCase.E);
            Character lowerL = new Character(lowerCase.L);
            Character lowerL2 = new Character(lowerCase.L);
            Character lowerO = new Character(lowerCase.O);
            Character upperW = new Character(upperCase.W);
            Character lowerO2 = new Character(lowerCase.O);
            Character lowerR = new Character(lowerCase.R);
            Character lowerL3 = new Character(lowerCase.L);
            Character lowerD = new Character(lowerCase.D);

            Character[] hello = { upperH, lowerE, lowerL, lowerL2, lowerO };
            Character[] world = { upperW, lowerO2, lowerR, lowerL3, lowerD };

            Word helloWord = new Word(hello);
            Word worldWord = new Word(world);

            Word[] helloWorld = { helloWord, worldWord };

            Sentence helloWorldSentence = new Sentence(helloWorld);

            helloWorldSentence.SayTheSentence();

            Console.ReadLine();
        }
    }

    public class Sentence
    {
        string theSentence;

        public Sentence(Word[] words)
        {
            TheSentence = MakeSentence(words);
        }

        private string MakeSentence(Word[] words)
        {
            string newSentence = "";

            for (int i = 0; i < words.Length - 1; i++)
            {
                newSentence += words[i].TheWord;
                newSentence += " ";
            }

            newSentence += words[words.Length - 1].TheWord;
            newSentence += ".";

            return newSentence;
        }

        public string TheSentence
        {
            get
            {
                return theSentence;
            }
            private set
            {
                theSentence = value;
            }
        }

        public void SayTheSentence()
        {
            Console.WriteLine(TheSentence);
        }
    }

    public class Word
    {
        string word;

        public Word(Character[] characters)
        {
            CheckForDoubles(characters);
            TheWord = ConstructWord(characters);
        }

        private void CheckForDoubles(Character[] characters)
        {
            foreach (Character character1 in characters)
            {
                int equalCount = 0;

                foreach (Character character2 in characters)
                {
                    if (character1.GetHashCode() == character2.GetHashCode())
                    {
                        equalCount++;
                    }
                    if (equalCount >= 2)
                    {
                        throw new System.ArgumentException("Each character must be unique.");
                    }
                }
            }

        }

        private string ConstructWord(Character[] letters)
        {
            string newWord = "";

            foreach (Character letter in letters)
            {
                newWord += letter.TheChar;
            }

            return newWord;

        }

        public string TheWord
        {
            get { return word; }
            private set { word = value; }
        }

    }

    public class Character
    {
        private char theChar;

        public Character(char theChar)
        {
            this.theChar = theChar;
        }

        public char TheChar
        {
            get { return theChar; }
        }
    }

    public class Alphabet
    {
        private char a;
        private char b;
        private char c;
        private char d;
        private char e;
        private char f;
        private char g;
        private char h;
        private char i;
        private char j;
        private char k;
        private char l;
        private char m;
        private char n;
        private char o;
        private char p;
        private char q;
        private char r;
        private char s;
        private char t;
        private char u;
        private char v;
        private char w;
        private char x;
        private char y;
        private char z;

        public Alphabet(char a,
            char b,
            char c,
            char d,
            char e,
            char f,
            char g,
            char h,
            char i,
            char j,
            char k,
            char l,
            char m,
            char n,
            char o,
            char p,
            char q,
            char r,
            char s,
            char t,
            char u,
            char v,
            char w,
            char x,
            char y,
            char z)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
            this.m = m;
            this.n = n;
            this.o = o;
            this.p = p;
            this.q = q;
            this.r = r;
            this.s = s;
            this.t = t;
            this.u = u;
            this.v = v;
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public char A
        {
            get { return a; }
            set { a = value; }
        }

        public char B
        {
            get { return b; }
            set { b = value; }
        }
        public char C
        {
            get { return c; }
            set { c = value; }
        }

        public char D
        {
            get { return d; }
            set { d = value; }
        }

        public char E
        {
            get { return e; }
            set { e = value; }
        }

        public char F
        {
            get { return f; }
            set { f = value; }
        }

        public char G
        {
            get { return g; }
            set { g = value; }
        }

        public char H
        {
            get { return h; }
            set { h = value; }
        }

        public char I
        {
            get { return i; }
            set { i = value; }
        }

        public char J
        {
            get { return j; }
            set { j = value; }
        }

        public char K
        {
            get { return k; }
            set { k = value; }
        }

        public char L
        {
            get { return l; }
            set { l = value; }
        }

        public char M
        {
            get { return m; }
            set { m = value; }
        }

        public char N
        {
            get { return n; }
            set { n = value; }
        }

        public char O
        {
            get { return o; }
            set { o = value; }
        }

        public char P
        {
            get { return p; }
            set { p = value; }
        }

        public char Q
        {
            get { return q; }
            set { q = value; }
        }

        public char R
        {
            get { return r; }
            set { r = value; }
        }

        public char S
        {
            get { return s; }
            set { s = value; }
        }

        public char T
        {
            get { return t; }
            set { t = value; }
        }

        public char U
        {
            get { return u; }
            set { u = value; }
        }

        public char V
        {
            get { return v; }
            set { v = value; }
        }

        public char W
        {
            get { return w; }
            set { w = value; }
        }

        public char X
        {
            get { return x; }
            set { x = value; }
        }

        public char Y
        {
            get { return y; }
            set { y = value; }
        }

        public char Z
        {
            get { return z; }
            set { z = value; }
        }
    }
}
