using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium126m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium126m";
        public override double halfLife { get; } = 1.64d;
        public override double atomicWeight { get; } = 125.91657d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin126()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.055d, new GammaParticle(57470.0, 0.02157)), new(0.88d, new GammaParticle(111790.0, 0.01109)), new(0.002d, new GammaParticle(170800.0, 0.00726)), new(0.0016d, new GammaParticle(175300.0, 0.00707)), new(0.0060999999999999995d, new GammaParticle(212320.0, 0.00584)), new(0.0022d, new GammaParticle(251750.0, 0.00492)), new(0.092d, new GammaParticle(258530.0, 0.0048)), new(0.0031d, new GammaParticle(266080.0, 0.00466)), new(0.063d, new GammaParticle(269260.0, 0.0046)), new(0.11599999999999999d, new GammaParticle(315930.0, 0.00392)), new(0.0025d, new GammaParticle(323900.0, 0.00383)), new(0.025d, new GammaParticle(362730.0, 0.00342)), new(0.012d, new GammaParticle(387520.0, 0.0032)), new(0.005d, new GammaParticle(402800.0, 0.00308)), new(0.0066d, new GammaParticle(417900.0, 0.00297)), new(0.0051d, new GammaParticle(433310.0, 0.00286)), new(0.02d, new GammaParticle(443940.0, 0.00279)), new(0.0037d, new GammaParticle(477980.0, 0.00259)), new(0.063d, new GammaParticle(501430.0, 0.00247)), new(0.01d, new GammaParticle(515790.0, 0.0024)), new(0.0064d, new GammaParticle(525460.0, 0.00236)), new(0.03d, new GammaParticle(571740.0, 0.00217)), new(0.0060999999999999995d, new GammaParticle(595840.0, 0.00208)), new(0.006999999999999999d, new GammaParticle(708030.0, 0.00175)), new(0.0064d, new GammaParticle(717700.0, 0.00173)), new(0.011000000000000001d, new GammaParticle(776850.0, 0.0016)), new(0.08199999999999999d, new GammaParticle(788300.0, 0.00157)), new(0.0083d, new GammaParticle(848420.0, 0.00146)), new(0.114d, new GammaParticle(905780.0, 0.00137)), new(0.99d, new GammaParticle(908580.0, 0.00136)), new(0.01d, new GammaParticle(945180.0, 0.00131)), new(0.0055000000000000005d, new GammaParticle(957900.0, 0.00129)), new(0.02d, new GammaParticle(962660.0, 0.00129)), new(0.027000000000000003d, new GammaParticle(977420.0, 0.00127)), new(0.0058d, new GammaParticle(1020410.0, 0.00122)), new(0.047d, new GammaParticle(1064850.0, 0.00116)), new(1.0d, new GammaParticle(1141110.0, 0.00109)), new(0.044000000000000004d, new GammaParticle(1192530.0, 0.00104)), new(0.0089d, new GammaParticle(1224200.0, 0.00101)), new(0.025d, new GammaParticle(1235950.0, 0.001)), new(0.012d, new GammaParticle(1280060.0, 0.00097)), new(0.017d, new GammaParticle(1314460.0, 0.00094)), new(0.027999999999999997d, new GammaParticle(1367350.0, 0.00091)), new(0.23199999999999998d, new GammaParticle(1377990.0, 0.0009)), new(0.035d, new GammaParticle(1406950.0, 0.00088)), new(0.019d, new GammaParticle(1495400.0, 0.00083)), new(0.0074d, new GammaParticle(1507200.0, 0.00082)), new(0.023d, new GammaParticle(1564410.0, 0.00079)), new(0.016d, new GammaParticle(1590210.0, 0.00078)), new(0.055999999999999994d, new GammaParticle(1611750.0, 0.00077)), new(0.29600000000000004d, new GammaParticle(1636500.0, 0.00076)), new(0.017d, new GammaParticle(1731300.0, 0.00072)), new(0.049d, new GammaParticle(1758300.0, 0.00071)), new(0.022000000000000002d, new GammaParticle(2035170.0, 0.00061)), new(0.026000000000000002d, new GammaParticle(2123330.0, 0.00058)), new(0.038d, new GammaParticle(2560100.0, 0.00048)), new(0.049d, new GammaParticle(2828600.0, 0.00044)), new(0.049489364800000005d, new GammaParticle(3753.0, 0.33036)), new(0.11041103691630383d, new GammaParticle(25044.0, 0.04951)), new(0.2066461480746843d, new GammaParticle(25271.0, 0.04906)), new(0.05843175857060315d, new GammaParticle(28579.0, 0.04338)), new(0.06994281500901196d, new GammaParticle(28810.0, 0.04304)), new(0.01151105643840882d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    