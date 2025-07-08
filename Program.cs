using System.Threading;
using System;
using System.Diagnostics;
using System.Reflection;

class BalanceManager //chatgpt moment ahh
{
    private static int balance = 100;

    public static int Get()
    {
        return balance;
    }
    public static void Write(int newBalance)
    {
        balance = newBalance;
    }


    private static int dluh = 0;
    private static int verimafie = 0;

    public static int GetDluh()
    {
        return dluh;
    }
    public static void WriteDluh(int newDluh)
    {
        dluh = newDluh;
    }

    public static int VeriMafie()
    {
        return verimafie;
    }
    public static void MafieVeri(int frVeri)
    {
        verimafie = frVeri;
    }
}

class Program
{


    static void progPujcitCartel() {
        Console.Clear();

        Console.WriteLine("=========================");
        Console.WriteLine("     Půjčit si peníze    ");
        Console.WriteLine("==doporučuju=to=zplatit==");
        Console.WriteLine("");

        Console.WriteLine("0) Exit");
        Console.WriteLine("10) Zaplatit dluh ("+BalanceManager.GetDluh()+"Kč)");
        Console.WriteLine("");
        Console.WriteLine("1) Půjčit si 100Kč");
        Console.WriteLine("2) Půjčit si 500Kč");
        Console.WriteLine("3) Půjčit si 1000Kč");
        Console.WriteLine("4) Půjčit si 2000Kč");
        Console.WriteLine("5) Půjčit si 5000Kč");
        Console.WriteLine("6) Půjčit si 10000Kč"); // půjčit tohle a all-in 🤑🤑🤑
        if (BalanceManager.VeriMafie() == 0) {
            Console.WriteLine("7) Půjčit si 50000Kč   (nemůžeš - jestě ti nevěří)");
            Console.WriteLine("8) Půjčit si 100000Kč  (nemůžeš - jestě ti nevěří)");
            Console.WriteLine("9) Půjčit si 1000000Kč (nemůžeš - jestě ti nevěří)"); 
        } else {
            Console.WriteLine("7) Půjčit si 50000Kč");
            Console.WriteLine("8) Půjčit si 100000Kč");
            Console.WriteLine("9) Půjčit si 1000000Kč"); 
        }
        Console.WriteLine("");

        if (BalanceManager.VeriMafie() == 0 & BalanceManager.GetDluh() > 50000) {
            Lose("Mafie ti nevěří, a dlužil jsi jim přes 50,000Kč.");
        } else if (BalanceManager.VeriMafie() == 1 & BalanceManager.GetDluh() > 2000000) {
            Lose("I když ti Mafie věřila, tak jsi jim dlužil 2,000,000Kč.");
        }

        Console.Write("Vybrat: "); int option = int.Parse(Console.ReadLine());
        if (option == 10 & BalanceManager.Get() > BalanceManager.GetDluh()) {
            Console.WriteLine("");
            if (BalanceManager.VeriMafie() == 0 & BalanceManager.GetDluh() > 0) {
                Console.Write("Úspéšné jsi zaplatil dluh, nyní ti už věří! (Press any key to continue)");
                BalanceManager.MafieVeri(1);
                Console.ReadKey();
            } else {}
            BalanceManager.Write((BalanceManager.Get()-BalanceManager.GetDluh()));
            BalanceManager.WriteDluh(0);
        } else if (option == 10 & BalanceManager.Get() == BalanceManager.GetDluh()) {
            Console.WriteLine("");
            Console.Write("Můžeš zaplatit dluh, ale zůstane ti 0Kč! pokračovat? (y/n): ");
            string BrokePay = Console.ReadLine();
            if (BrokePay == "y") {
                BalanceManager.Write((BalanceManager.Get()-BalanceManager.GetDluh()));
                BalanceManager.WriteDluh(0);
            } else {
                progPujcitCartel();
            }
        } else if (option == 10 & BalanceManager.Get() < BalanceManager.GetDluh()) {
            Console.WriteLine("");
            Console.Write("Nemůžeš zaplatit dluh, protože nemáš dostatek peněz. (Press any key to continue)");
            Console.ReadKey();
            progPujcitCartel();
        }

        if (option == 0) {
            Main();
        } else if (option == 1) {
            Console.WriteLine("");
            Console.Write("Právě jsis půjčil 100kč, zplať to. (Press any key to continue)");
            BalanceManager.WriteDluh(BalanceManager.GetDluh()+100);
            BalanceManager.Write(BalanceManager.Get()+100);
            Console.ReadLine();
            Main();
        } else if (option == 2) {
            Console.WriteLine("");
            Console.Write("Právě jsis půjčil 500kč, zplať to. (Press any key to continue)");
            BalanceManager.WriteDluh(BalanceManager.GetDluh()+500);
            BalanceManager.Write(BalanceManager.Get()+500);
            Console.ReadLine();
            Main();
        } else if (option == 3) {
            Console.WriteLine("");
            Console.Write("Právě jsis půjčil 1000kč, zplať to. (Press any key to continue)");
            BalanceManager.WriteDluh(BalanceManager.GetDluh()+1000);
            BalanceManager.Write(BalanceManager.Get()+1000);
            Console.ReadLine();
            Main();
        } else if (option == 4) {
            Console.WriteLine("");
            Console.Write("Právě jsis půjčil 2000kč, zplať to. (Press any key to continue)");
            BalanceManager.WriteDluh(BalanceManager.GetDluh()+2000);
            BalanceManager.Write(BalanceManager.Get()+2000);
            Console.ReadLine();
            Main();
        } else if (option == 5) {
            Console.WriteLine("");
            Console.Write("Právě jsis půjčil 5000kč, zplať to. (Press any key to continue)");
            BalanceManager.WriteDluh(BalanceManager.GetDluh()+5000);
            BalanceManager.Write(BalanceManager.Get()+5000);
            Console.ReadLine();
            Main();
        } else if (option == 6) {
            Console.WriteLine("");
            Console.Write("Právě jsis půjčil 10000kč, zplať to. (Press any key to continue)");
            BalanceManager.WriteDluh(BalanceManager.GetDluh()+10000);
            BalanceManager.Write(BalanceManager.Get()+10000);
            Console.ReadLine();
            Main();
        } else if (option == 7) {
            if (BalanceManager.VeriMafie() == 1) {
                Console.WriteLine("");
                Console.Write("Právě jsis půjčil 50000kč, zplať to. (Press any key to continue)");
                BalanceManager.WriteDluh(BalanceManager.GetDluh()+50000);
                BalanceManager.Write(BalanceManager.Get()+50000);
                Console.ReadLine();
                Main();
            } else {
                Console.WriteLine("");
                Console.Write("Tuhle částku si nemůžeš půjčit, nejdřív ti musí věřit. (Press any key to continue)");
                Console.ReadLine();
                progPujcitCartel();
            }
        } else if (option == 8) {
            if (BalanceManager.VeriMafie() == 1) {
                Console.WriteLine("");
                Console.Write("Právě jsis půjčil 100000kč, zplať to. (Press any key to continue)");
                BalanceManager.WriteDluh(BalanceManager.GetDluh()+100000);
                BalanceManager.Write(BalanceManager.Get()+100000);
                Console.ReadLine();
                Main();
            } else {
                Console.WriteLine("");
                Console.Write("Tuhle částku si nemůžeš půjčit, nejdřív ti musí věřit. (Press any key to continue)");
                Console.ReadLine();
                progPujcitCartel();
            }
        } else if (option == 9) {
            if (BalanceManager.VeriMafie() == 1) {
                Console.WriteLine("");
                Console.Write("Právě jsis půjčil 1000000kč, zplať to. (Press any key to continue)");
                BalanceManager.WriteDluh(BalanceManager.GetDluh()+1000000);
                BalanceManager.Write(BalanceManager.Get()+1000000);
                Console.ReadLine();
                Main();
            } else {
                Console.WriteLine("");
                Console.Write("Tuhle částku si nemůžeš půjčit, nejdřív ti musí věřit. (Press any key to continue)");
                Console.ReadLine();
                progPujcitCartel();
            }
        } else {
            progPujcitCartel();
        }
    }
   static void progCoinflip() {
        Console.Clear();

        Console.WriteLine("=========================");
        Console.WriteLine("         Coinflip        ");
        Console.WriteLine("=========================");
        Console.WriteLine("");

        Console.WriteLine("0) Exit");
        Console.WriteLine("");
        Console.WriteLine("1) Coinflip (50/50)");
        Console.WriteLine("2) Coinflip (pro)");
        Console.WriteLine("3) Coinflip XXXL (plus-sized community)");
        Console.WriteLine("4) Epsteinflip (super-hard!)");
        Console.WriteLine("");

        Console.Write("Vybrat: "); int option = int.Parse(Console.ReadLine());
        if (option == 0) {
            Main();
        }
        Console.Write("Vsadíš: "); int bet = int.Parse(Console.ReadLine());

        if (bet > BalanceManager.Get()) {
            Console.WriteLine();
            Console.Write("Máš jenom "+BalanceManager.Get()+" peněz!");
            Console.ReadKey();
            progCoinflip();
        } else if (bet < 1) {
            Console.WriteLine("");
            Console.Write("Nemůžeš vsadit mínus nebo nulu (jinak by to doslova fungovalo naopak)");
            Console.ReadKey();
            progCoinflip();
        }

        Console.Clear();
        if (option == 1) {
            Console.WriteLine("=========================");
            Console.WriteLine(" Level: Coinflip (50/50) ");
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.Write("Vyber stranu (1/2): ");
            int coinflip = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 3);
            Console.WriteLine("Coinflip: " + randomNumber);

            if (coinflip == randomNumber) {
                Console.WriteLine("🎉 Vyhrál jsi!");
                Console.Write("Získáváš "+bet+"! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()+bet);
                Console.ReadKey();
                progCoinflip();
            } else {
                Console.WriteLine("😔 Porhrál jsi!");
                Console.Write("Bylo ti odebráno "+bet+" z účtu! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()-bet);
                Console.ReadKey();
                progCoinflip();
            }

        } else if (option == 2) {
            Console.WriteLine("=========================");
            Console.WriteLine(" Level: Coinflip (pro)   ");
            Console.WriteLine("========výhra=2x=========");
            Console.WriteLine("");
            Console.Write("Vyber stranu (1/5): ");
            int coinflip = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine("Coinflip: " + randomNumber);

            if (coinflip == randomNumber) {
                Console.WriteLine("🎉 Vyhrál jsi!");
                Console.Write("Získáváš "+(bet*2)+"! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()+(bet*2));
                Console.ReadKey();
                progCoinflip();
            } else {
                Console.WriteLine("😔 Porhrál jsi!");
                Console.Write("Bylo ti odebráno "+bet+" z účtu! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()-bet);
                Console.ReadKey();
                progCoinflip();
            }
        } else if (option == 3) {
            Console.WriteLine("=========================");
            Console.WriteLine(" Level: Coinflip XXXL    ");
            Console.WriteLine("========výhra=5x=========");
            Console.WriteLine("");
            Console.Write("Vyber stranu (1/10): ");
            int coinflip = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            Console.WriteLine("Coinflip: " + randomNumber);

            if (coinflip == randomNumber) {
                Console.WriteLine("🎉 Vyhrál jsi!");
                Console.Write("Získáváš "+(bet*5)+"! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()+(bet*5));
                Console.ReadKey();
                progCoinflip();
            } else {
                Console.WriteLine("😔 Porhrál jsi!");
                Console.Write("Bylo ti odebráno "+bet+" z účtu! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()-bet);
                Console.ReadKey();
                progCoinflip();
            }
        } else if (option == 4) {
            Console.WriteLine("=========================");
            Console.WriteLine(" Level: Epsteinflip      ");
            Console.WriteLine("=======výhra=100x========");
            Console.WriteLine("");
            Console.Write("Vyber stranu (1/100): ");
            int coinflip = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            Console.WriteLine("Coinflip: " + randomNumber);

            if (coinflip == randomNumber) {
                Console.WriteLine("🎉 Vyhrál jsi!");
                Console.Write("Získáváš "+(bet*100)+"! (Press any key to continue)");
                BalanceManager.Write(BalanceManager.Get()+(bet*100));
                Console.ReadKey();
                progCoinflip();
            } else {
                Console.WriteLine("😔 Porhrál jsi!");
            }
        } else {
            Main();
        }
    }

    static void progAllIn() {
        Console.Clear();

        Console.WriteLine("=========================");
        Console.WriteLine("          All-In         ");
        Console.WriteLine("==double=all=your=money==");
        Console.WriteLine("");

        Console.WriteLine("0) Exit");
        Console.WriteLine("");
        Console.WriteLine("1) Play");
        Console.WriteLine("");

        Console.Write("Vybrat: "); int option = int.Parse(Console.ReadLine());
        if (option == 0) {
            Main();
        } else if (option == 1) {
        } else {
            Main();
        }
        Console.Write("[poslední varování] Chceš spustit hru? (y/n): "); string fr = (Console.ReadLine());
        if (fr == "n") {
            Main();
        } else if (fr == "y") {
        } else {
            Main();
        }

        Console.Clear();

        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 3);

        Thread.Sleep(100);
        Console.WriteLine("Rolling the 2D dice...");
        Thread.Sleep(1000);
        Console.WriteLine("Calculating (100% není jen Thread.Sleep(1000) :D)");
        Thread.Sleep(500);
        if (randomNumber == 1) {
            if (BalanceManager.Get() > 1000000) {
                Console.Clear();
                Console.WriteLine("You lost!");
                Thread.Sleep(100);
                Console.Write("(Press any key to continue)");
                BalanceManager.Write(0);
                Console.ReadKey();
                Main();
            } else {
                Console.Clear();
                Console.WriteLine("You won!");
                Thread.Sleep(100);
                Console.Write("Zdvojnásobil jsi svoje penize na "+BalanceManager.Get()*2+"! (Press any key to continue)");
                BalanceManager.Write((BalanceManager.Get()*2));
                Console.ReadKey();
                Main();
            }
        } else {
            Console.Clear();
            Console.WriteLine("You lost!");
            Thread.Sleep(100);
            Console.Write("(Press any key to continue)");
            BalanceManager.Write(0);
            Console.ReadKey();
            Main();
        }
    }

    static void prog777() {
        Console.Clear();

        Console.WriteLine("=========================");
        Console.WriteLine("            777          ");
        Console.WriteLine("====best=game=ever=fr====");
        Console.WriteLine("");

        Console.WriteLine("0) Exit");
        Console.WriteLine("");
        Console.WriteLine("1) Play (120kč/hra)");
        Console.WriteLine("2) Play Hardcore (670000Kč/hra) c🥵mming soon");
        Console.WriteLine("");

        Console.Write("Vybrat: ");
        if (!int.TryParse(Console.ReadLine(), out int option)) {
            prog777();
            return;
        }

        if (option == 0) {
            return; // konec
        }
        else if (option == 1) {
            string[] symbols = { "🥭", "🍒", "🍋", "🍉", "⭐", "🍇" };
            Random rand = new Random();

            while (true) {
                string o1 = symbols[rand.Next(symbols.Length)];
                string o2 = symbols[rand.Next(symbols.Length)];
                string o3 = symbols[rand.Next(symbols.Length)];

                Console.Clear();
                Console.WriteLine("  __________");
                Console.WriteLine(" /          \\");
                Console.WriteLine("|            | O");
                Console.WriteLine($"|({o1})({o2})({o3})|//");
                Console.WriteLine("|            |/");
                Console.WriteLine("|____________|");
                Console.WriteLine("");
                Console.WriteLine("Press any button to Spin");
                Console.Write("Press 'x' to exit.");

                var key = Console.ReadKey(true);
                if (key.KeyChar == 'x' || key.KeyChar == 'X') {
                    Main();
                }

                if (o1 == o2 && o2 == o3) {
                    Console.WriteLine("Vyhrál jsi! 🎉 Obdržel jsi "+BalanceManager.GetDluh()+(BalanceManager.Get()/5)+"Kč!");
                    Console.WriteLine("Press any button to exit");
                    Console.ReadKey();
                    Main();
                }
            }
        }
        else {
            prog777();
        }
    }



    static void progGuessNumber() {
        Console.Clear();

        Console.WriteLine("=========================");
        Console.WriteLine("     Guess the number    ");
        Console.WriteLine("=========================");
        Console.WriteLine("");

        Console.WriteLine("0) Exit");
        Console.WriteLine("");
        Console.WriteLine("1) Play | (1-5)   | 2x   bet");
        Console.WriteLine("2) Play | (1-10)  | 3x   bet");
        Console.WriteLine("3) Play | (1-15)  | 5x   bet");
        Console.WriteLine("4) Play | (1-30)  | 10x  bet");
        Console.WriteLine("5) Play | (1-50)  | 25x  bet");
        Console.WriteLine("6) Play | (1-75)  | 50x  bet");
        Console.WriteLine("7) Play | (1-100) | 100x bet");
        Console.WriteLine("8) Play | (1-150) | 500x bet");
        Console.WriteLine("");

        Console.Write("Vybrat: "); int option = int.Parse(Console.ReadLine());
        if (option == 0) {
            Main();
        } else if (option == 1) {
        } else {
            progGuessNumber();
        }
    }


    

    static void Lose(string message) {
        Console.Clear();
        Console.WriteLine("                                                                 ");
        Console.WriteLine("██    ██  ██████  ██    ██     ██       ██████  ███████ ████████ ");
        Console.WriteLine(" ██  ██  ██    ██ ██    ██     ██      ██    ██ ██         ██    ");
        Console.WriteLine("  ████   ██    ██ ██    ██     ██      ██    ██ ███████    ██    ");
        Console.WriteLine("   ██    ██    ██ ██    ██     ██      ██    ██      ██    ██    ");
        Console.WriteLine("   ██     ██████   ██████      ███████  ██████  ███████    ██    ");
        Console.WriteLine(message);
        Console.WriteLine("");
        Console.Write("Press any button to exit...");
        Console.ReadKey();
        Console.ReadKey();
        Environment.Exit(0);
    }








    static void Main() {
        int BalanceChars = (BalanceManager.Get()).ToString().Length;

        Console.Clear();
        Console.WriteLine("                                                          ");
        Console.WriteLine("       ██████  █████  ███████ ██ ███    ██  ██████        ");
        Console.WriteLine("▄ ██ ▄██      ██   ██ ██      ██ ████   ██ ██    ██ ▄ ██ ▄");
        Console.WriteLine(" ████ ██      ███████ ███████ ██ ██ ██  ██ ██    ██  ████ ");
        Console.WriteLine("▀ ██ ▀██      ██   ██      ██ ██ ██  ██ ██ ██    ██ ▀ ██ ▀");
        Console.WriteLine("       ██████ ██   ██ ███████ ██ ██   ████  ██████        ");
        Console.WriteLine("                                                          ");


        Console.WriteLine("Vyber Možnost:");
        Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Balance: " + BalanceManager.Get() +"kč"+ new string(' ', 56 - BalanceChars) + "║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════════╣");
        Console.WriteLine("║ 1) Coinflip                   8) Půjčit si peníze od Mexické mafie ║");
        Console.WriteLine("║ 2) All-in                     9) Koupit Celé Casino                ║");
        Console.WriteLine("║ 3) 777 (W.I.P)                                                     ║");
        Console.WriteLine("║ 4) Guess the number (W.I.P)                                        ║");
        Console.WriteLine("║ 5)                                                                 ║");
        Console.WriteLine("║ 6)                                                                 ║");
        Console.WriteLine("║ 7)                                                                 ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");

        Console.WriteLine("┌──(fiala㉿casino)-[~]");
        Console.Write("└─$ "); int userInput = int.Parse(Console.ReadLine());

        Console.Clear();
        if (userInput == 8) {
            progPujcitCartel();
        } else if (userInput == 1) {
            progCoinflip();
        } else if (userInput == 2) {
            progAllIn();
        } else if (userInput == 3) {
            prog777();
        } else if (userInput == 4) {
            progGuessNumber();
        }
    }
}