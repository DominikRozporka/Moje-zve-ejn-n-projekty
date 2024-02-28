using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_na_opičí_syndrom
{
    internal class OtazkyAOdpovedi
    {
        public static string[] dotaz = new string[] {
            "Venku je zima a ty musíš jít ven, co si na sebe vezmeš abys měl co největší jistotu, že ti bude teplo?", // otázka číslo 0
            "Jsi doma a chceš si natočit co nejvíce vody z kohoutku na pití k počítači,\n máš na výběr 4 čisté předměty, který si vybereš?", // otázka číslo 1
            "Máš syna který se rád vzteká a má neobvyklé záliby a ve školce dětem zbourává stavby z kostek,\n ale tvůj syn nijak nikomu fyzicky neubližuje (Nemlatí nikoho a podobně), co uděláš?", // otázka číslo 2
            "Vláda začala nutit lidi nosit roušky kvůli novému typu viru, jaký máš na to názor?", // otázka číslo 3
            "Co si myslíš nebo víš o lidech kteří provádí meditační cvičení?", // otázka číslo 4
            "Co si myslíš nebo víš o lidech kteří trénují telekinezi(Pohybování předměty pomocí mysli)?", // otázka číslo 5
            "Co si myslíš nebo víš o lidech kteří trénují telepatii?(Čtení myšlenek a posílání myšlenek nějaké osobě?)", // otázka číslo 6
            "Co si myslíš nebo víš o astrálním cestování(Vystupování svým astrálním tělem (duší) ven z těla)?", // otázka číslo 7
            "Kolik má noha židlý?"}; // otázka číslo 8
        public static string[] odpovediA = new string[] {
            "Župan", "Skleničku", "Půjdu s ním k děckýmu psychologovi jestli nemá nějakou diagnózu", "Je mi to jedno",
            "Myslím si, že to jsou negativní blázni", "Že jim to nic pozitivního nepřinese", "Že to může být užitečný, ale pozor aby to člověku neutvořilo ego", "Vím, že je to nesmysl", "Jednu židly protože židle bez nohy je taky židle, akorát rozbitá"};

        public static string[] odpovediB = new string[] {
            "Velmi roztrhanou a velmi děravou bundu", "Hrnec", "Naplácám mu na zadek", "Je to správný kvůli ochraně zdraví lidí",
            "Že se duševně dále rozvíjejí a čistí se jim mysl a zlepšuje se jim vědomí", "Myslím si, že jsou to hloupí lidé", "Myslím si, že trpí paranoidní schizofrenií", "Myslím, že je to hloupost a nic takového neexistuje", "Polovinu židle"};

        public static string[] odpovediC = new string[] {
            "Doktorský plášť", "Dvou litrovou vázu, která se vejde do ruky s rovným hrdlem", "Naplácám mu na zadek a domluvím mu", "Když vláda něco nařídí, tak se to má vždy dodržovat",
            "Vím, že to jsou negativní blázni", "Že to může být prospěšný, ale pozor aby to člověku neutvořilo ego", "Vím, že nic takového neexistuje", "Může to být velmi zajímavé a posunout člověka v duševním vývoji dál", "Noha žádný židle nemá"};

        public static string[] odpovediD = new string[] {
            "Pytel od brambor", "Hrníček", "Vysvětlím mu, že vztek je špatný a celkově ho budu vychovávat\na nebudu ho nutit chodit do školky pokud nechce,\n jestli nemám čas na dítě, tak jsem se neměl množit", "Je to nemorální a je to zásah do osobní svobody člověka",
            "Jsou to hlupáci", "Že nic takového jako telekineze neexistuje", "Myslím si, že nic takového neexistuje", "Že astrální cestování provádí negativní blázni", "Noha má 5 židlý."};

        public static bool beh = false;
        private static string[] spravneOdpovedi = new string[] { "a", "c", "d", "d", "b", "c", "a", "c", "a" };
        public static int body = 0;
        public static int cisloOtazky = 0;
        public static string odpovediUzivatele = "";
        public static void VypoctiVysledek()
        {
            string[] odpovediUzivateleSplited = odpovediUzivatele.Split(' ');
            for (int i = 0; i <= spravneOdpovedi.Length - 1; i++)
            {
                if (spravneOdpovedi[i] == odpovediUzivateleSplited[i])
                {
                    ++body;
                }
            }
        }
    }
}
