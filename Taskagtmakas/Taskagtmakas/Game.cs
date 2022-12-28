using System;
using System.Collections.Generic;
using System.Text;

namespace Taskagtmakas
{
    class Game
    {
        private int osayisi;
        public Game(int osayisi)
        {
            this.osayisi = osayisi;
        }
        List<string> k = new List<string>();
        List<string> isim = new List<string>();

        public void oyna()
        {
            osayisi = osayisi + 1;
            string[,] sinifim = new string[osayisi, osayisi];
            for (int i = 1; i < osayisi; i++)
            {
                Console.WriteLine(i + "kisinin adı ne?");
                sinifim[i, 0] = Console.ReadLine();
                Console.WriteLine(i + "Tas(t),makas(m),kagit(k)");


                sinifim[i, i] = Console.ReadLine();
            }
            int o = osayisi;
            int o1 = o - 1;
            for (int i = 1; i < osayisi; i++)


            {

                o = o - 1;

                if (sinifim[i, i] == sinifim[o, o])
                {
                    Console.WriteLine("Berabere");

                }
                else if (sinifim[i, i] != sinifim[o, o])
                {
                    string t = sinifim[i, i];
                    string t1 = sinifim[o, o];
                    if (o1 == 2)
                    {
                        if (t == "m")
                        {
                            if (t1 == "t")
                            {
                                Console.WriteLine(sinifim[o, 0] + " kazandı");
                                break;

                            }
                            else if (t1 == "k")
                            {
                                Console.WriteLine(sinifim[i, 0] + " kazandı");
                                break;
                            }
                        }
                        else if (t == "t")
                        {
                            if (t1 == "m")
                            {
                                Console.WriteLine(sinifim[i, 0] + " kazandı");
                                break;
                            }
                            else if (t1 == "k")
                            {
                                Console.WriteLine(sinifim[o, 0] + " kazandı");
                                break;
                            }
                        }
                        else if (t == "k")
                        {
                            if (t1 == "m")
                            {
                                Console.WriteLine(sinifim[o, 0] + " kazandı");
                                break;
                            }
                            else if (t1 == "t")
                            {
                                Console.WriteLine(sinifim[i, 0] + " kazandı");
                                break;
                            }
                        }
                    }



                    else if (t == "m")
                    {
                        if (t1 == "t")
                        {
                            Console.WriteLine(sinifim[o, 0] + " kazandı");
                            isim.Add(sinifim[o, 0]);

                        }
                        else if (t1 == "k")
                        {
                            Console.WriteLine(sinifim[i, 0] + " kazandı");
                            isim.Add(sinifim[i, 0]);
                        }
                    }
                    else if (t == "t")
                    {
                        if (t1 == "m")
                        {
                            Console.WriteLine(sinifim[i, 0] + " kazandı");
                            isim.Add(sinifim[i, 0]);
                        }

                        else if (t1 == "k")
                        {
                            Console.WriteLine(sinifim[o, 0] + " kazandı");
                            isim.Add(sinifim[o, 0]);
                        }
                    }
                    else if (t == "k")
                    {
                        if (t1 == "m")
                        {
                            Console.WriteLine(sinifim[o, 0] + " kazandı");

                            isim.Add(sinifim[o, 0]);
                        }
                        else if (t1 == "t")
                        {
                            Console.WriteLine(sinifim[i, 0] + " kazandı");
                            isim.Add(sinifim[i, 0]);
                        }
                    }
                }
            }
            for (int t3 = 0; t3 < isim.Count; t3++)
            {


                Console.WriteLine(isim[t3] + "Tas(t),makas(m),kagit(k)");


                k.Add ( Console.ReadLine());
            }
             o = isim.Count + 1;


            for (int i = o; i < isim.Count; i++)


            {

                o = o - 1;


                if (k[i] == k[o])
                {
                    Console.WriteLine("Berabere");

                }
                else if (k[i] != k[o])
                {
                    string t = k[i];
                    string t1 = k[o];
                    if (o == 2)
                    {
                        if (t == "m")
                        {
                            if (t1 == "t")
                            {
                                Console.WriteLine(isim[o] + " kazandı");
                                break;

                            }
                            else if (t1 == "k")
                            {
                                Console.WriteLine(isim[i] + " kazandı");
                                break;
                            }
                        }
                        else if (t == "t")
                        {
                            if (t1 == "m")
                            {
                                Console.WriteLine(isim[i] + " kazandı");
                                break;
                            }
                            else if (t1 == "k")
                            {
                                Console.WriteLine(isim[o] + " kazandı");
                                break;
                            }
                        }
                        else if (t == "k")
                        {
                            if (t1 == "m")
                            {
                                Console.WriteLine(isim[o] + " kazandı");
                                break;
                            }
                            else if (t1 == "t")
                            {
                                Console.WriteLine(isim[i] + " kazandı");
                                break;
                            }
                        }
                    }



                    else if (t == "m")
                    {
                        if (t1 == "t")
                        {
                            Console.WriteLine(isim[o] + " kazandı");
                            isim.Add(isim[o]);

                        }
                        else if (t1 == "k")
                        {
                            Console.WriteLine(isim[i] + " kazandı");
                            isim.Add(isim[i]);
                        }
                    }
                    else if (t == "t")
                    {
                        if (t1 == "m")
                        {
                            Console.WriteLine(isim[i] + " kazandı");
                            isim.Add(isim[i]);
                        }

                        else if (t1 == "k")
                        {
                            Console.WriteLine(isim[o] + " kazandı");
                            isim.Add(isim[o]);
                        }
                    }
                    else if (t == "k")
                    {
                        if (t1 == "m")
                        {
                            Console.WriteLine(isim[o] + " kazandı");

                            isim.Add(isim[o]);
                        }
                        else if (t1 == "t")
                        {
                            Console.WriteLine(isim[i] + " kazandı");
                            isim.Add(isim[i]);
                        }





                    }



                }

            }
        }
    }
}

