using System;

namespace collectionsprac
{
    class Program
    {
// 1) Create an array to hold integer values 0 through 9
            static void Main(string[] args)
            {
                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                foreach (int i in array)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
// 2) Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
                static void Main(string[] args)        
                {
                    string[] myFriends = new string[] { "Tim", "Martin", "Nikki", "Sara" };
                    for (int i = 0; i < myFriends.Length; i++)
                    {
                        Console.WriteLine($"I own a {myFriends[i]}");
                    }
                // return myFriends;
            }
        }   
    }
// 3) Create an array of length 10 that alternates between true and false values, starting with true
                static void Main(bool[] args)        
                    {
                        bool[] new_arr = new bool[10];
                        int start = 0;
                        int end = new_arr.Length;
                        for(int i = start; i < end; i +=2)
                            {
                                new_arr[i] = true;
                                new_arr[i+1] = false;
                            }
                        foreach (bool x in new_arr)
                        {
                            Console.Write($"{x}");
                        }
                    }
                }
            }
// 4) - ??????????? Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!) - ???????????
                static List<string> create_list()
                    {
                        List<string> ice_cream = new List<string>();
                        ice_cream.Add("Vanilla");
                        ice_cream.Add("Blueberry");
                        ice_cream.Add("Cherry");
                        ice_cream.Add("Coffe");
                        foreach (string icecream in ice_cream)
                        {
                        Console.WriteLine("-" + icecream);
                        }
                        Console.WriteLine(ice_cream.Count);
                        Console.WriteLine(ice_cream[3]);
                        return ice_cream;
                    }
        // 5) Create a dictionary that will store both string keys as well as string values
                    static void creat_dict()
                    {
                        string[] myFriends = new string[] { "Tim", "Martin", "Nikki", "Sara"};            
                        List<string> ice_cream = new List<string>();
                        ice_cream.Add("Vanilla");
                        ice_cream.Add("Blueberry");
                        ice_cream.Add("Cherry");
                        ice_cream.Add("Coffe");
                        Dictionary<string,string> profile = new Dictionary<string,string>();
                        foreach (var name in myFriends)
                        {
                            profile.Add(name, null);
                        }
                        Random rand = new Random();
                        foreach (var name in myFriends)
                        {
                            int randInx = rand.Next(ice_cream.Count);
                            profile[name] = ice_cream[randInx];
                            ice_cream.RemoveAt(randInx);
                        }

                        foreach (var entry in profile)
                        {
                            Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
                        }
                    }





                    static void Main(string[] args)
                        {
                            string place = "World!";
                            Console.WriteLine($"Hello {place}");
                            create_arr_0_9();
                            create_array_str();
                            create_arr_true_false();
                            Console.WriteLine();
                            create_list();
                            Console.WriteLine();
                            creat_dict();



                        }
            
            
        }
    }