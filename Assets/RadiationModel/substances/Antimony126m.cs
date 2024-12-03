using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony126m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126m";
        public override double halfLife { get; } = 1149.0d;
        public override double atomicWeight { get; } = 125.90728d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.8140000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium126()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.81d, new GammaParticle(414500.0, 0.00299)), new(0.0146d, new GammaParticle(620000.0, 0.002)), new(0.8109999999999999d, new GammaParticle(666100.0, 0.00186)), new(0.78d, new GammaParticle(694800.0, 0.00178)), new(0.00040500000000000003d, new GammaParticle(726000.0, 0.00171)), new(0.001054d, new GammaParticle(730700.0, 0.0017)), new(0.0158d, new GammaParticle(928200.0, 0.00134)), new(0.017d, new GammaParticle(1034900.0, 0.0012)), new(0.0049d, new GammaParticle(1061600.0, 0.00117)), new(0.002189d, new GammaParticle(1191000.0, 0.00104)), new(0.001865d, new GammaParticle(1290000.0, 0.00096)), new(0.0032d, new GammaParticle(1476100.0, 0.00084)), new(0.00073d, new GammaParticle(1589000.0, 0.00078)), new(0.0013383151342406d, new GammaParticle(4135.0, 0.29984)), new(0.0036561204638934546d, new GammaParticle(27202.0, 0.04558)), new(0.006808417996077197d, new GammaParticle(27473.0, 0.04513)), new(0.0019484506286190216d, new GammaParticle(31093.0, 0.03988)), new(0.0023712644150293495d, new GammaParticle(31359.0, 0.03954)), new(0.0004228137864103277d, new GammaParticle(31698.0, 0.03911)) } },
            { 0.18600000000000003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony126()), new(5.8e-07d, new GammaParticle(17700.0, 0.07005)), new(0.01108032d, new GammaParticle(3941.0, 0.3146)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    