﻿namespace MyMoney
{
    public class Bank
    {
        public Money Reduce(Calculation source, string to)
        {
            return source.Reduce(to);
            
        }
    }
}