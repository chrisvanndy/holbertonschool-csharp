﻿using System;

    public struct Dog
    {
        public Dog(string _name, float _age, string _owner, Rating _rating)
        {
            name = _name;
            age = _age;
            owner = _owner;
            rating = _rating;
        } 
        public string name;
        public float age;
        public string owner;
        public Rating rating;
    }
    /* public struct Dog
    {
        public string name;
        public float age;
        public string owner;
        public Rating rating;

    } */
       public enum Rating
    {
        Good,
        Great,
        Excellent
    }
