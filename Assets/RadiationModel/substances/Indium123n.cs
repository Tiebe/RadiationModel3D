using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium123n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 122.91267d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium123()), new(0.006868d, new GammaParticle(31500.0, 0.03936)), new(0.7276d, new GammaParticle(880700.0, 0.00141)), new(0.272d, new GammaParticle(1019000.0, 0.00122)), new(0.28559999999999997d, new GammaParticle(1027400.0, 0.00121)), new(0.68d, new GammaParticle(1166000.0, 0.00106)), new(0.041515747937279995d, new GammaParticle(3571.0, 0.3472)), new(0.03354014906544444d, new GammaParticle(24001.0, 0.05166)), new(0.06292710894079633d, new GammaParticle(24209.0, 0.05121)), new(0.01765594016282289d, new GammaParticle(27367.0, 0.0453)), new(0.02101056879375924d, new GammaParticle(27581.0, 0.04495)), new(0.0033546286309363493d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    