using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony124n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124n";
        public override double halfLife { get; } = 1212.0d;
        public override double atomicWeight { get; } = 123.90598d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony124()), new(4.57e-05d, new GammaParticle(10863.0, 0.11413)), new(3.37e-05d, new GammaParticle(25980.0, 0.04772)), new(0.1287608008d, new GammaParticle(3941.0, 0.3146)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    