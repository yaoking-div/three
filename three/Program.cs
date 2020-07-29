//#include<stdio.h>
using System;
using System.Security.Cryptography;
using System.Xml.Serialization;
//命名空间 。 名字空间 。java: package
namespace three

{
    //抽离概念：v.抽象
    //=>定义 一个类
    //概念实际化， 实际的个体：实体  v.具体化
    //概念的一个  实际的例子：实例 instance 

    class threepeople
    {
        //成员变量:状态
        public string Name;
        public bool Gender;
        public int Age;

        int HungerLevel;
        //成员方法：功能 、动作v.
        public void Birth()
        {
            Gender = DateTime.Now.Ticks % 2 == 0;
            Age = 0;
            HungerLevel = 100;
        }
        public bool Dead()
        {
            Age = -1;
            return HungerLevel < 0;

        }

        //人工智能 字母检索
        public string Say(string words)
        {
            if (words == "饿")
            {
                if (HungerLevel < 60) return "饿了";
                else return "不饿";
            }
            if (words == "xxx") 
            { }
        }

        public void Walk()
        {
            Walk(10);
        }
        public void Run()
        {
            Walk(100);

        }
        public void Food() { }
        public void Walk(int speed)
        {
            HungerLevel = HungerLevel - speed * 1;

        }
        public void Eat(int Food) 
        {
            HungerLevel = Food *2;
        }

    }
    //继承 
    class Student:threepeople
    {
        int money;
        public void Earn(int k) { }
        void Cost(int count) 
        {

        }
    }


    class Cafeteria
    {
        int FoodHeap;
        int Income;
        int Charge(int Cost) 
        {
            Income += Cost;
            int Food = Cost * 2;
            if(FoodHeap < Food) { 
                return 0;
            }
            else
            {

            }
            return Food;
        }
      void SupplyFood()
        {
            FoodHeap += 100;
        
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        void Tellstory() 
        {
            int a = 3;
            Student hendry = new Student();
            hendry.Name="321";
            hendry.Birth();
            hendry.Earn(800);

            Student kecai = new Student();
            kecai.Name = "123";
            kecai.Birth();
            hendry.Earn(1000);

        }

    }
}
