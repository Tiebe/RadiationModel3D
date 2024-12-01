using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony123n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony123n";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 122.90702d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony123()), new(0.6d, new GammaParticle(127800.0, 0.0097)), new(0.018000000000000002d, new GammaParticle(147600.0, 0.0084)), new(1.0d, new GammaParticle(200400.0, 0.00619)), new(0.016d, new GammaParticle(375700.0, 0.0033)), new(1.09d, new GammaParticle(441900.0, 0.00281)), new(1.12d, new GammaParticle(955800.0, 0.0013)), new(1.0d, new GammaParticle(1088600.0, 0.00114)), new(0.0415813502512d, new GammaParticle(3941.0, 0.3146)), new(0.11156436550422227d, new GammaParticle(26111.0, 0.04748)), new(0.20829791916396992d, new GammaParticle(26359.0, 0.04704)), new(0.0592553495043975d, new GammaParticle(29821.0, 0.04158)), new(0.0715212068518078d, new GammaParticle(30069.0, 0.04123)), new(0.012265857347410283d, new GammaParticle(30387.0, 0.0408)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    