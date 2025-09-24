namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Pyytää käyttäjältä laskutoimituksen ja tarkistaa sen
        /// </summary>
        /// <returns></returns>
        static int ValitseLaskuToimitus()

        {
            while (true)
            {

                Console.WriteLine("Valitse laskutoimituksen numero: ");
                Console.WriteLine("1) Yhteenlasku 2) Vähennyslasku 3) Kertolasku 4) Jakolasku");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int Toimitus) && Toimitus > 0 && Toimitus < 5)
                {
                    return Toimitus;
                }
                else
                {
                    Console.WriteLine("Valitse annettujen vaihtoehtojen väliltä.");
                }
            }
        }
        /// <summary>
        /// Pyytää käyttäjältä kaksi numeroa ja tarkistaa ne
        /// </summary>
        /// <returns></returns>
        static int Numerot()
        {
            while (true)
            {
                Console.WriteLine("Anna luku: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int Luku))
                    return Luku;
                Console.WriteLine("Anna kelvollinen numero.");
            }
        }
        /// <summary>
        /// Jos valittu toimitus on yhteen niin laskee luvut yhteen
        /// </summary>
        /// <param name="Toimitus"></param>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns></returns>
        static int YhteenLasku(int Toimitus, int Luku1, int Luku2)
        {
            if (Toimitus == 1)
            {
                return Luku1 + Luku2;
            }
            return 0;
        }
        /// <summary>
        /// Jos valittu toimitus on vähennys niin laskee lukujen vähennyksen
        /// </summary>
        /// <param name="Toimitus"></param>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns></returns>
        static int VähennysLasku(int Toimitus, int Luku1, int Luku2)
        {
            if (Toimitus == 2)
            {
                return Luku1 - Luku2;
            }
            return 0;
        }
        /// <summary>
        /// Jos valittu toimitus on kertolasku niin laskee luvut kertolaskuna
        /// </summary>
        /// <param name="Toimitus"></param>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns></returns>
        static int Kertolasku(int Toimitus, int Luku1, int Luku2)
        {
            if (Toimitus == 3)
            {
                return Luku1 * Luku2;
            }
            return 0;
        }
        /// <summary>
        /// Jos valittu toimitus on jakolasku niin laskee luvut jakolaskuna
        /// </summary>
        /// <param name="Toimitus"></param>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns></returns>
        static int Jakolasku(int Toimitus, int Luku1, int Luku2)
        {
            if (Toimitus == 4)
            {
                if (Luku2 != 0)
                {
                    return Luku1 / Luku2;
                }
                else
                {
                    Console.WriteLine("Nollalla ei voi jakaa.");
                    return 0;
                }
            }
            return 0;
        }
        /// <summary>
        /// Varmistaa minkä laskun käyttäjä valitsi ja tulostaa sen
        /// </summary>
        /// <param name="Toimitus"></param>
        /// <param name="Yhteen"></param>
        /// <param name="Vähennys"></param>
        /// <param name="Kerto"></param>
        /// <param name="Jako"></param>
        /// <param name="Luku1"></param>
        /// <param name="Luku2"></param>
        /// <returns></returns>
        static int TulostaLasku(int Toimitus, int Yhteen, int Vähennys, int Kerto, int Jako,int Luku1, int Luku2)
        {
            if (Toimitus == 1)
            {
                Console.WriteLine($"Tulos: {Luku1} + {Luku2} = {Yhteen}");
            }
            else if (Toimitus == 2)
            {
                Console.WriteLine($"Tulos: {Luku1} - {Luku2} = {Vähennys}");
            }
            else if (Toimitus == 3)
            {
                Console.WriteLine($"Tulos: {Luku1} * {Luku2} = {Kerto}");
            }
            else if (Toimitus == 4)
            {
                Console.WriteLine($"Tulos: {Luku1} / {Luku2} = {Jako}");
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int Toimitus = ValitseLaskuToimitus();
            int Luku1 = Numerot();
            int Luku2 = Numerot();
            int Yhteen = YhteenLasku(Toimitus, Luku1, Luku2);
            int Vähennys = VähennysLasku(Toimitus, Luku1, Luku2);
            int Kerto = Kertolasku(Toimitus, Luku1, Luku2);
            int Jako = Jakolasku(Toimitus, Luku1, Luku2);
            int Vastaus = TulostaLasku(Toimitus, Yhteen, Vähennys, Kerto, Jako, Luku1, Luku2);

        }
    }
}