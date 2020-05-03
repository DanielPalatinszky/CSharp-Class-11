using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Class_11
{
    class A
    {
        private int a;

        public A(int a)
        {
            this.a = a;
        }
    }

    class B : A
    {
        private int b;

        public B(int a, int b) : base(a)
        {
            this.b = b;
        }
    }

    class C : B
    {
        private int c;

        public C(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }
    }

    class Test
    {
        private int a;
        private int b;
        private int c;

        public Test(int a, int b, int c) : this(b, c)
        {
            this.a = a;
        }

        public Test(int b, int c) : this(c)
        {
            this.b = b;
        }

        public Test(int c)
        {
            this.c = c;
        }
    }
}
