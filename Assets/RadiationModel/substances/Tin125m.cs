using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin125m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin125m";
        public override double halfLife { get; } = 571.2d;
        public override double atomicWeight { get; } = 124.90782d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony125()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00022379d, new GammaParticle(278560.0, 0.00445)), new(0.00043785d, new GammaParticle(310960.0, 0.00399)), new(0.973d, new GammaParticle(331940.0, 0.00374)), new(0.000973d, new GammaParticle(386520.0, 0.00321)), new(0.00011676d, new GammaParticle(430030.0, 0.00288)), new(0.0018876200000000002d, new GammaParticle(589610.0, 0.0021)), new(0.00151788d, new GammaParticle(642960.0, 0.00193)), new(0.00013622d, new GammaParticle(779500.0, 0.00159)), new(0.0007005599999999999d, new GammaParticle(840830.0, 0.00147)), new(0.0008465100000000001d, new GammaParticle(1017570.0, 0.00122)), new(0.00012649000000000002d, new GammaParticle(1025460.0, 0.00121)), new(0.00018487d, new GammaParticle(1057770.0, 0.00117)), new(0.00035027999999999996d, new GammaParticle(1093270.0, 0.00113)), new(0.00031136d, new GammaParticle(1151700.0, 0.00108)), new(0.00011676d, new GammaParticle(1304420.0, 0.00095)), new(0.00016541d, new GammaParticle(1349370.0, 0.00092)), new(0.0010119200000000001d, new GammaParticle(1368610.0, 0.00091)), new(0.006801270000000001d, new GammaParticle(1404060.0, 0.00088)), new(0.00173194d, new GammaParticle(1483770.0, 0.00084)), new(9.730000000000001e-05d, new GammaParticle(1581960.0, 0.00078)), new(0.00108003d, new GammaParticle(1615380.0, 0.00077)), new(0.00015568d, new GammaParticle(1633110.0, 0.00076)), new(0.00030163d, new GammaParticle(1736070.0, 0.00071)), new(0.00018487d, new GammaParticle(1913660.0, 0.00065)), new(0.00013622d, new GammaParticle(1947500.0, 0.00064)), new(1.946e-05d, new GammaParticle(2113000.0, 0.00059)), new(0.0017098104524439612d, new GammaParticle(3941.0, 0.3146)), new(0.005055874288883105d, new GammaParticle(26111.0, 0.04748)), new(0.009439645797018495d, new GammaParticle(26359.0, 0.04704)), new(0.002685334126932558d, new GammaParticle(29821.0, 0.04158)), new(0.003241198291207598d, new GammaParticle(30069.0, 0.04123)), new(0.0005558641642750395d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    