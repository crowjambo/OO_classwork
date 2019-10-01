
//Programa turi leisti įvesti naują studentų grupę(pavadinimas, semestro numeris), grupei priskirti dėstomus dalykus(pavadinimas, kreditų kiekis) ir grupei priklausančius studentus. (10 taškų)
//    Programa turi leisti įvesti pasirinkto studento pažymius ir priskirti juos atitinkamiems dalykams. (5 taškai)
//    Programa turi apskaičiuoti ir išvesti studento bendrą pažymių vidurkį. (5 taškai)
//    Programa turi apskaičiuoti ir išvesti visos grupės bendrą pažymių vidurkį. (5 taškai)
//    Programa turi išvesti grupės, pagal didžiausią vidurkį, studentų Top 3. (5 taškai)



//EVALDAS PAULAUSKAS PI18E


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
