using System.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace console
{
    class Person{
        public string first_name;
        public string last_name;
        public int id;
        public string address;
        public  Person(string first_name,string last_name,int id,string address){
            this.address=address;
            this.id=id;
            this.first_name=first_name;
            this.last_name=last_name;
        }
    }

    class Income{
        public int id;
        public int salary;
    public  Income(int id,int month,int salary){
        this.id=id;
        this.salary=salary;
    }

    }
    class Grade{
        public Grade(int id,int math,int chemistry){
            this.id=id;
            this.math=math;
            this.chemistry=chemistry;
        }
        public int id;
        public int math;
        public int chemistry;
    }

    static class Calculate{

        // public int number;
        // public Calculate(int number){
        //     this.number=number;
        // }

        public static void toFarsi(this String name){
            Console.WriteLine("یاسین");
        }

        public static void DateChanger(this DateTime thisDate){
            PersianCalendar pc = new PersianCalendar();
            Console.WriteLine("Persian Calendar:    {0}, {1}/{2}/{3}\n",  
                      pc.GetDayOfWeek(thisDate), 
                      pc.GetMonth(thisDate), 
                      pc.GetDayOfMonth(thisDate),  
                      pc.GetYear(thisDate)
                      );
        }
        

        public static void parse(this int number){

            //soluition from scratch
            /* list<int> l=new list<int>;
            while(number!=0){
                list.Add(number%1000);
                // Console.Write(number%1000);
                number/=1000;
            }
            for(int i=list.Count-1;i>0;i--){
                Console.Write(list.get(i)+",")
            }
            Console.Write(list.get(0));*/

            //alternative way
            Console.WriteLine("console: {0:n}",number);
        }
    }
    class Pride{
        private int speed;
        public int speed_check{
            get{
                return speed;
            }set{
                if(value>=120){
                    Console.WriteLine("you will die soon");
                }else
                {
                    speed=value;
                }
            }
        }  
          }
    class Machine{
        private int max_speed;
        private int time_rate_0_100;
        private string color;
        private string type;
    public bool prime_check(int number){
        bool temp=true;
        for(int i=2;i<number/2;i++){
            if(number%i==0){
                temp=false;
            }
        }
        return temp;
    }
    }

    class Parent{
        public void func1(){
            Console.WriteLine("i'm parent method");
        }
    } 
    class Child:Parent{
        public void func2(){
            Console.WriteLine("i'm child method");
        }
    }
    class Program
    {
        static double sum(List<int> numbers,int length){
            // calculating avg
            double sum=0;
            foreach 
            (var item in numbers){
                sum+=item;
            }
            return sum/numbers.Count;
        }
        static double sum(int length,List<int> numbers){
            // calculating sum
            double sum=0;
            foreach (var item in numbers){
                sum+=item;
            }
            return sum;
        }
        static void Main(string[] args)
        {

        //pool prpgram
        //     bool temp=true;
        //     while (temp)
        //     {         
        //     try{
        //     Console.WriteLine("enter input #1");
        //     int in1=Int32.Parse(Console.ReadLine());
        //     Console.WriteLine("enter input #2");
        //     int in2=Int32.Parse(Console.ReadLine());   
        //     Console.WriteLine(in1+in2);
        //     temp=false;
        // }catch(FormatException e){
        //     Console.WriteLine("please enter int only");
        // }finally{
        // }
        //     }

        // determine name of day
        //  Console.WriteLine("enter number of day");
        //  int day=Int32.Parse(Console.ReadLine());
        //  switch (day)
        //  {
        //      case 1:
        //      Console.WriteLine("saturday");
        //      break;
        //      case 2:
        //      Console.WriteLine("sunday");
        //      break;
        //      case 3:
        //      Console.WriteLine("monday");
        //      break;
        //      case 4:
        //      Console.WriteLine("tuesday");
        //      break;
        //      case 5:
        //      Console.WriteLine("wednesday");
        //      break;
        //      case 6:
        //      Console.WriteLine("thursday");
        //      break;
        //      case 7:
        //      Console.WriteLine("friday");
        //      break;
        //      default:
        //      Console.WriteLine("Error");
        //      break;
        //  }
        
        //read string of names
        // int n=Int32.Parse(Console.ReadLine());
        // string[] names=new String[n];
        // for (int i=0;i<n;i++){
        //     names[i]=Console.ReadLine();
        // }

        //overloading example
        // Console.WriteLine("enter number of integers");
        // int n=Int32.Parse(Console.ReadLine());
        // List<int> integers = new List<int>();
        //         for (int i=0;i<n;i++){
        //     integers.Add(Int32.Parse(Console.ReadLine()));
        // }
        // Console.WriteLine("mean: "+sum(integers,integers.Count));
        // Console.WriteLine("sum: "+sum(integers.Count,integers));

        // check to see insurance speed
        // Machine machine=new Machine();
        // Console.WriteLine("enter number");
        // int integer=Int32.Parse(Console.ReadLine());
        // Console.WriteLine(machine.prime_check(integer));

        // polymorphism example
        // Parent parent=new Parent();
        // Child child =new Child();
        // Console.WriteLine("Parrent:");
        // parent.func1();
        // Console.WriteLine("Child:");
        // child.func1();
        // child.func2();

        //extenction method
        // number.parse();
        // DateTime.Now.DateChanger();
        // "yasin".toFarsi();

        //LINQ usage example
        /*Grade[] grades={
            new Grade(0,10,15),new Grade(1,12,14),new Grade(1,5,6)
        };
        Person[] persons={
            new Person("yasin","fallah",0),
            new Person("ali","dehghani",1),
            new Person("reza","hadi",2)
        };

        var joined_list=(from p in persons
                        join g in grades
                        on p.id equals g.id
                        select new{
                            name =p.first_name,
                            math=g.math,
                            chemistry=g.chemistry,
                            avg=(g.math+g.chemistry)/2
                        });
        foreach(var l in joined_list){
            Console.WriteLine(l);
        }
    */

    int[] numbers={1,3,4,5,6,8,4,5,6,3,3};

    var check= numbers.Any(a=> a==2);
    // Console.WriteLine(check);
    
    string[] names={"rahim","ali","hassan","mamad","sara"};

    var namesWithI= names.Where(a=> a.ToLower().StartsWith("s"));

    foreach (var item in namesWithI){
        // Console.WriteLine(item);
    }

            Person[] persons={
            new Person("yasin","fallah",0,"yazd"),
            new Person("ali","dehghani",1,"esfahan"),
            new Person("reza","hadi",2,"tehran")
        };

        Income[] incomes={
            new Income(0,10,1200),
            new Income(1,11,1300),
            new Income(2,12,1200),
            new Income(0,10,1100),
            new Income(1,11,1400),
            new Income(2,12,1700),
            new Income(0,10,1600),
            new Income(1,11,1100),
            new Income(2,12,1400),
        };

        var checkReachest=persons.GroupJoin(incomes,
                                            per=> per.id ,
                                            inc=> inc.id,
                                            (per, salaryGroup) => new {
                                                name=per.first_name,
                                                sum_of_salary=salaryGroup.ToArray().Sum(s=> s.salary)})
                                            .OrderByDescending(s=>s.sum_of_salary).Last();
        Console.WriteLine(checkReachest);



    }
}
}
