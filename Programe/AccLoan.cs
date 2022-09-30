using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
        public class Loan
        {
            public string Type { get; set; }
            public double RateOfInt { get; set; }
        }
        public class Customer
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public List<Loan> Loans = new List<Loan>();
        }
        public class AccountType
        {
            public string Type { get; set; }
            public List<Customer> custmerList = new List<Customer>();
        }
        internal class AccLoan
        {
      static void Main(string[] args)
        {
            List<AccountType> accountList = new List<AccountType>();
            {
                new AccountType
                {
                    Type="saving",
                    custmerList =new List<Customer>()
                    {
                        new Customer()
                        {
                            Id=1,
                            Name="radhika",
                            Loans =new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type= "car loan",
                                    RateOfInt =8.8,
                                },
                                new Loan()
                                {
                                    Type ="home loan",
                                    RateOfInt  =7.7,
                                }
                            }
                        },
                        new Customer()
                        {
                            Id=2,
                            Name="kavita",
                            Loans =new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type= "home loan",
                                    RateOfInt =6.8,
                                }
                            }
                        },
                        new Customer()
                        {
                            Id=3,
                            Name="savita",
                            Loans =new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type= "education loan",
                                    RateOfInt =9.8,
                                }
                            }
                        },
                        new Customer()
                        {
                            Id=4,
                            Name="shubham",
                            Loans =new List<Loan>()
                            {
                                new Loan()
                                {
                                    Type= "bike loan",
                                    RateOfInt =10,
                                }
                            }
                        }
                    }
               };
       
    
             foreach (AccountType a in accountList)
                {
                    Console.WriteLine(a.Type);
                    foreach (Customer c in a.custmerList)
                    {
                        Console.WriteLine($" \t name={c.Name}-->id={c.Id}");
                        foreach (Loan l in c.Loans)
                        {
                            Console.WriteLine($"\t TypeofLoan= {l.Type}-->RateofLoan={l.RateOfInt}");
                        }
                    }
                }
            }
        }
    }
}

