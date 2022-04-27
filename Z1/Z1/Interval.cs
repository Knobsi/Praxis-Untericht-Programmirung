using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    internal class Interval
    {
        int a;
        int b;
        public Interval(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public Interval()
        {
            this.a = 0;
            this.b = -1;
        }

        public Interval(Interval i)
        {
            a = i.a;
            b = i.b;
        }
        public bool IsEmpty()
        {
            if(a == 0 || b == -1)
            {
                return true;
            }
            return false;
        }
        public int GetLowerBound()
        {
            if(a <b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public int GetUpperBound()
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public override string ToString()
        {
            if(IsEmpty())
            {
                return ("[]");
            }
            else
            {
                return ($"[{a},{b}]");
            }
        }
        public bool Contains(int i)
        {
            for (int x = a; x < b; x++)
            {
                if(x ==b)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(Interval i)
        {
            if(IsEmpty())
            {
                if(i.IsEmpty())
                {
                    
                }
            }
            if(GetLowerBound() > i.a && GetUpperBound() < i.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDisjoint(Interval i)
        {
            if(IsEmpty() || i.IsEmpty())
            {
                return true;
            }
            return false;
        }
    }
}
