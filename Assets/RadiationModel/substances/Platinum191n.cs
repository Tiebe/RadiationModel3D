using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum191n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum191n";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 190.96184d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum191()), new(0.00216d, new GammaParticle(48200.0, 0.02572)), new(0.12140000000000001d, new GammaParticle(91100.0, 0.01361)), new(0.4666864328d, new GammaParticle(11070.0, 0.112)), new(0.025469022478509d, new GammaParticle(65122.0, 0.01904)), new(0.04353679056155385d, new GammaParticle(66832.0, 0.01855)), new(0.014648978973512566d, new GammaParticle(75821.0, 0.01635)), new(0.01883858695993716d, new GammaParticle(76725.0, 0.01616)), new(0.004189607986424594d, new GammaParticle(77832.0, 0.01593)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    