using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt58m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58m";
        public override double halfLife { get; } = 32760.0d;
        public override double atomicWeight { get; } = 57.93578d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cobalt58()), new(0.000397d, new GammaParticle(24889.0, 0.04981)), new(0.009150081408000001d, new GammaParticle(800.0, 1.5498)), new(0.08435228603338311d, new GammaParticle(6915.0, 0.1793)), new(0.1648793706672852d, new GammaParticle(6930.0, 0.17891)), new(0.03419458329933169d, new GammaParticle(7677.0, 0.1615)), new(0.03419458329933169d, new GammaParticle(7677.0, 0.1615)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    