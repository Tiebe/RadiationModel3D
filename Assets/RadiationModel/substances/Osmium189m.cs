using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium189m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium189m";
        public override double halfLife { get; } = 20916.0d;
        public override double atomicWeight { get; } = 188.95818d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium189()), new(3.2099999999999998e-06d, new GammaParticle(30810.0, 0.04024)), new(0.217756d, new GammaParticle(10393.0, 0.1193)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    