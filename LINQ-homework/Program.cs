namespace LINQ_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() // ex1
            {
                0,1,2,3,4,5,6,7,8,9,10
            };

            var result = from x in list where (x % 2) == 0 select x;

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------");

            List<int> l = new List<int>()  /// ex 2
            {
                0,1,3,6,-7,-8,9,10,-11,13,14
            };

            var res = from p in l where p > 0 where p < 12 select p;

            foreach (int i in res)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------");

            List<int> Num = new List<int>() //ex3
            {
                8,9,6,7
            };

            var Sq = from nums in Num let Sqr = nums * nums where Sqr > 30 select Sqr;
            foreach (int i in Sq)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------");

            List<int> frequency = new List<int>() // ex 4
            {
                3,4,5,7,8,1
            };

            var frq = from f in frequency group f by f into d select d;

            foreach (var i in frq)
            {
                Console.WriteLine("Number: " + i.Key + " appears " + i.Count() + " times");
            }

            Console.WriteLine("----------");

            List<string> Str = new List<string>()  // ex 5
            {
                "Hello", "apple"
            };
            string word = "apple";

            Dictionary<char, int> dic = word
                .GroupBy(x => x)
                .ToDictionary(g => g.Key, g => g.Count());
            foreach (var str in dic)
            {
                Console.WriteLine($"Charecter: {str.Key}, Count: {str.Value}");
            }
            Console.WriteLine("------------");

            List<string> week = new List<string>() // ex 6
            {
                "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"
            };

            week.OrderBy(x => x).ToList();
            foreach (var x in week)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------");

            List<int> display = new List<int>() // ex7
            {
                5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
            };

            var dis = from d in display group d by d into y select y;
            Console.WriteLine($"Number  Number*frequency  frequency");

            foreach (var play in dis)
            {
                Console.WriteLine(play.Key + "\t" + play.Sum() + " \t\t\t" + play.Count());
            }
            Console.WriteLine("--------------");

            List<string> country = new List<string>()  // ex 8
            {
                "Rome","London","Nairobi","California","Azerbaijan","Albania"
            };
            var country2 = (from c in country where c.StartsWith("L") select c).ToList();
            var country1 = (from Country in country where Country.EndsWith("a") select Country).ToList();
            foreach (var item1 in country1)
            {
                Console.WriteLine(item1);
            }
            foreach (var item in country2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            List<int> numbers = new List<int>() /// ex 9
            {
                55, 200, 740, 76, 230, 482 ,95
            };
            var numbers2 = from n in numbers where (n > 80) select n;
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");

            //Console.Write("Input the number of members on the List: "); // ex 10
            //int count = Convert.ToInt32(Console.ReadLine());

            //List<int> numberrs = new List<int>();

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write($"Member {i}: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    numberrs.Add(number);
            //}

            //Console.Write("Input the value above which you want to display the members of the List: ");
            //int threshold = Convert.ToInt32(Console.ReadLine());

            //List<int> greaterNumbers = numberrs.FindAll(x => x > threshold);

            //Console.WriteLine("The numbers greater than {0} are:", threshold);
            //foreach (int number in greaterNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            Console.WriteLine("---------------");

            List<int> templist = new List<int>()   // ex 11
            {
                5,7,13,24,6,9,8,7
            };
            templist.Sort();
            templist.Reverse();

            foreach (int number in templist)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("___---___");

            foreach (int numb in templist)
            { Console.WriteLine(numb); }

            Console.WriteLine("----------------------");

            //string words;
            //Console.WriteLine("Input the string:");    //ex12
            //words = Console.ReadLine();

            //var UpWord = WordFilt(words);
            //Console.WriteLine("\n The UPPER CASE words : ");
            //foreach (var StrRet in UpWord)
            //{
            //    Console.WriteLine(StrRet);

            //}
            //static IEnumerable<string> WordFilt(string myword)
            //{
            //    var Upword = myword.Split(' ').Where(x => String.Equals(x, x.ToUpper(),
            //        StringComparison.OrdinalIgnoreCase));
            //    return Upword;
            //}
            Console.WriteLine("----------0");

            //Console.WriteLine("Input number of string to store in the array :");  // ex13
            //int count = int.Parse(Console.ReadLine());

            //string[] strings = new string[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"ELEMENTS:  [{ i}] ");
            //    strings[i] = Console.ReadLine();
            //}
            // string ress = string.Join(" , ", strings);
            //Console.WriteLine("Here is the string below created with elements of the above array :");
            //Console.WriteLine(ress);

            Console.WriteLine("----------------------");

            //List<Students> students = new List<Students>()   // ex14
            // {
            //     new Students { Id = 1, Name ="Peri", Grade=550},
            //     new Students { Id = 2, Name = "Ali", Grade=180},
            //     new Students { Id = 3,Name ="Beyim", Grade=500},
            //     new Students { Id = 4,Name ="Fazil", Grade=300},
            //     new Students { Id = 5,Name ="Akif", Grade=400}
            // };

            //Console.Write("Which maximum grade point (1st, 2nd, 3rd, ...) you want to find: ");
            //int j = Convert.ToInt32(Console.ReadLine());
            //var sortedStudents = students.OrderByDescending(x => x.Grade).ToList();

            //if (j >= 1 && j <= sortedStudents.Count)
            //{
            //    Students nthMaxStudent = sortedStudents[j - 1];
            //    Console.WriteLine($"ID: {nthMaxStudent.Id}, Name: {nthMaxStudent.Name}, Grade: {nthMaxStudent.Grade}");
            //}
            Console.WriteLine("------------------------");

            List<string> extensions = new List<string>()  // ex 15
            {
                "aaa.frx","bbb.TXT" , "xyz.dbf","abc.pdf","aaaa.PDF","xyz.frt","abc.xml","ccc.txt"," zzz.txt"

            };
            var resExtension = extensions.Select(file => Path.GetExtension(file).ToLower())
                              .GroupBy(extension => extension)
                              .Select(group => new { Extension = group.Key, Count = group.Count() })
                              .OrderBy(group => group.Extension);

            foreach (var itemEx in resExtension)
            {
                Console.WriteLine($"{itemEx.Count} File(s) with {itemEx.Extension} Extension");
            }

            Console.WriteLine("-------------");

            List<char> chars = new List<char>()  //ex 17
            {
                'm', 'n','o','p','q'
            };
            Console.WriteLine("Here is the list of items :");

            foreach (var itemEx in chars)
            { Console.WriteLine(itemEx); }

            var itemRomove = 'o';
            List<char> charList = chars.Where(x => x != itemRomove).ToList();
            Console.WriteLine("Here is the list after removing the item 'o' from the list :");
            foreach (var itemEx in charList)
            { Console.WriteLine(itemEx); }
            Console.WriteLine("-------------------------");

            List<char> Charsitem = new List<char>()  // ex18
            {
                'm','n','o','p','q'
            };
            Console.WriteLine("Here is the list of items :");
            foreach (var Charsi in Charsitem)
            {
                Console.WriteLine(Charsi);
            }
            var RemoveChar = 'p';
            List<char> Removeitem = Charsitem.Where(x => x != RemoveChar).ToList();
            Console.WriteLine("Here is the list after removing the item 'p' from the list :");
            foreach (var charI in Removeitem)
            {
                Console.WriteLine(charI);
            }
            Console.WriteLine("--------------------------");

            List<char> Charnineteenth = new List<char>()  // ex19
            {
                'm','n','o','p','q'
            };
            Console.WriteLine("Here is the list of items :");
            foreach (var itemss in Charnineteenth)
            {
                Console.WriteLine(itemss);
            }
            var charRemov = 'q';
            List<char> removeChar = Charnineteenth.Where(x => x != charRemov).ToList();
            Console.WriteLine("Here is the list after removing item 'q' from the list :");
            foreach (var charIX in removeChar)
            { Console.WriteLine(charIX); }
            Console.WriteLine("-----------------------");
            List<char> Chartwenty = new List<char>()  // ex20
            {
                'm','n','o','p','q'
            };
            Console.WriteLine("Here is the list of items :");
            foreach (var item in Chartwenty)
            {
                Console.WriteLine(item);
            }
            Chartwenty.RemoveAt(3);
            Console.WriteLine("Here is the list after removing item index 3 from the list :");
            foreach (var itemA in Chartwenty)
            {
                Console.WriteLine(itemA);
            }
            Console.WriteLine("-----------------------");

            List<char> Chartwentyone = new List<char>()  // ex21
            {
                'm','n','o','p','q'
            };
            Console.WriteLine("Here is the list of items :");
            foreach (var item in Chartwentyone)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Here is the list after removing the three items starting from the item index 1 from the list :");
            Chartwentyone.RemoveRange(1, 3);

            foreach (var items in Chartwentyone)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("-----------------------");

            char[] charset = { 'X', 'Y', 'Z' };  // ex 23
            int[] intset = { 1, 2, 3, 4 };
            Console.WriteLine("The cartesian product are :");
            var SetProduct = from Letterlist in charset from numberList in intset select new { Letterlist, numberList };
            foreach (var item in SetProduct)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            char[] CharSet = { 'X', 'Y', 'Z' };  // ex 24
            int[] IntSet = { 1, 2, 3 };
            string[] StringSet = { "Orange", "Green" };
            Console.WriteLine("The cartesian product are :");
            var Product = from letter in CharSet from num in IntSet from colour in StringSet select new { letter, num, colour };
            foreach (var item in Product)
            {
                Console.WriteLine(item);
            }

            List<string> ListCOuntry = new List<string>()
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };
            Console.WriteLine("Here is the arranged list :");
            var CityOrder = ListCOuntry.OrderBy(x => x.Length).ThenBy(x => x);
            foreach (var city in CityOrder)
            { Console.WriteLine(city); }
            Console.WriteLine("---------------------");

            List<string> Countrys = new List<string>()  // ex 29
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };
            var citySplit = from i in Enumerable.Range(0, Countrys.Count)
                            group Countrys[i] by i / 3;

            foreach (var city in citySplit)
                cityView(string.Join(";  ", city.ToArray()));
        }
        static void cityView(string cityMetro)
        {
            Console.WriteLine(cityMetro);
            Console.WriteLine("-- here is a group of cities --\n");
            Console.WriteLine("-----------------------");
        }

    }
}
