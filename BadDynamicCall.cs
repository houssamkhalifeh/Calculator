class BadDynamicCall
{
    class WithFoo
    {
        public void Foo(int i) { }
    }

    class WithoutFoo { }

    public static void Test(string[] args)
    {
        dynamic o = new WithoutFoo();
        o.Foo(3);
    }
}