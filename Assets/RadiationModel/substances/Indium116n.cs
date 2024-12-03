using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium116n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116n";
        public override double halfLife { get; } = 2.18d;
        public override double atomicWeight { get; } = 115.90557d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium116()), new(0.37200000000000005d, new GammaParticle(162390.0, 0.00763)), new(0.04014007488d, new GammaParticle(3571.0, 0.3472)), new(0.10393921315233046d, new GammaParticle(24001.0, 0.05166)), new(0.19500790460099524d, new GammaParticle(24209.0, 0.05121)), new(0.05471485903081876d, new GammaParticle(27367.0, 0.0453)), new(0.06511068224667432d, new GammaParticle(27581.0, 0.04495)), new(0.010395823215855565d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    