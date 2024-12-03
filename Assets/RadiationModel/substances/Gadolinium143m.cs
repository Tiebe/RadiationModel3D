using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium143m";
        public override double halfLife { get; } = 110.0d;
        public override double atomicWeight { get; } = 142.92691d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium143()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.065065d, new GammaParticle(117570.0, 0.01055)), new(0.0037180000000000004d, new GammaParticle(131100.0, 0.00946)), new(0.010985d, new GammaParticle(210900.0, 0.00588)), new(0.845d, new GammaParticle(271940.0, 0.00456)), new(0.01014d, new GammaParticle(304200.0, 0.00408)), new(0.034645d, new GammaParticle(389470.0, 0.00318)), new(0.002535d, new GammaParticle(428100.0, 0.0029)), new(0.005915d, new GammaParticle(497300.0, 0.00249)), new(0.005915d, new GammaParticle(545300.0, 0.00227)), new(0.15717d, new GammaParticle(588000.0, 0.00211)), new(0.00338d, new GammaParticle(590800.0, 0.0021)), new(0.0058305d, new GammaParticle(594300.0, 0.00209)), new(0.01183d, new GammaParticle(625230.0, 0.00198)), new(0.097175d, new GammaParticle(668100.0, 0.00186)), new(0.0038025d, new GammaParticle(698800.0, 0.00177)), new(0.00845d, new GammaParticle(776800.0, 0.0016)), new(0.054924999999999995d, new GammaParticle(785560.0, 0.00158)), new(0.10731500000000001d, new GammaParticle(798890.0, 0.00155)), new(0.049855000000000003d, new GammaParticle(824430.0, 0.0015)), new(0.005408d, new GammaParticle(830100.0, 0.00149)), new(0.0055769999999999995d, new GammaParticle(836300.0, 0.00148)), new(0.002535d, new GammaParticle(845500.0, 0.00147)), new(0.017745d, new GammaParticle(890520.0, 0.00139)), new(0.021124999999999998d, new GammaParticle(906960.0, 0.00137)), new(0.043095d, new GammaParticle(916530.0, 0.00135)), new(0.0054925d, new GammaParticle(926600.0, 0.00134)), new(0.02028d, new GammaParticle(984930.0, 0.00126)), new(0.0046475d, new GammaParticle(993100.0, 0.00125)), new(0.01352d, new GammaParticle(1008280.0, 0.00123)), new(0.03042d, new GammaParticle(1041350.0, 0.00119)), new(0.00845d, new GammaParticle(1059300.0, 0.00117)), new(0.007605d, new GammaParticle(1087300.0, 0.00114)), new(0.00845d, new GammaParticle(1087300.0, 0.00114)), new(0.008112000000000001d, new GammaParticle(1138900.0, 0.00109)), new(0.007605d, new GammaParticle(1144220.0, 0.00108)), new(0.0055769999999999995d, new GammaParticle(1158200.0, 0.00107)), new(0.007605d, new GammaParticle(1162800.0, 0.00107)), new(0.008957d, new GammaParticle(1196900.0, 0.00104)), new(0.0055769999999999995d, new GammaParticle(1213100.0, 0.00102)), new(0.041405000000000004d, new GammaParticle(1219210.0, 0.00102)), new(0.002535d, new GammaParticle(1225800.0, 0.00101)), new(0.00676d, new GammaParticle(1231800.0, 0.00101)), new(0.002535d, new GammaParticle(1276900.0, 0.00097)), new(0.00845d, new GammaParticle(1293300.0, 0.00096)), new(0.003549d, new GammaParticle(1297600.0, 0.00096)), new(0.002535d, new GammaParticle(1329300.0, 0.00093)), new(0.00507d, new GammaParticle(1354400.0, 0.00092)), new(0.010985d, new GammaParticle(1373600.0, 0.0009)), new(0.012675d, new GammaParticle(1386690.0, 0.00089)), new(0.028730000000000002d, new GammaParticle(1404560.0, 0.00088)), new(0.0065910000000000005d, new GammaParticle(1489800.0, 0.00083)), new(0.01183d, new GammaParticle(1503400.0, 0.00082)), new(0.019435d, new GammaParticle(1629300.0, 0.00076)), new(0.000845d, new GammaParticle(1633300.0, 0.00076)), new(0.0048165000000000005d, new GammaParticle(1675900.0, 0.00074)), new(0.010985d, new GammaParticle(1702500.0, 0.00073)), new(0.007605d, new GammaParticle(1746400.0, 0.00071)), new(0.026195d, new GammaParticle(1793210.0, 0.00069)), new(0.07689499999999999d, new GammaParticle(1807140.0, 0.00069)), new(0.03042d, new GammaParticle(1820270.0, 0.00068)), new(0.007605d, new GammaParticle(1886000.0, 0.00066)), new(0.002535d, new GammaParticle(2338900.0, 0.00053)), new(1.3908d, new GammaParticle(511000.0, 0.00243)), new(0.14885193265660202d, new GammaParticle(6603.0, 0.18777)), new(0.22271851140967783d, new GammaParticle(40901.0, 0.03031)), new(0.40187389283593977d, new GammaParticle(41541.0, 0.02985)), new(0.12660656842816573d, new GammaParticle(47146.0, 0.0263)), new(0.15927106308263247d, new GammaParticle(47645.0, 0.02602)), new(0.032664494654466754d, new GammaParticle(48248.0, 0.0257)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    