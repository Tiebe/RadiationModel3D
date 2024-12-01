using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth204n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth204n";
        public override double halfLife { get; } = 0.00107d;
        public override double atomicWeight { get; } = 203.98088d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth204()), new(0.037000000000000005d, new GammaParticle(41000.0, 0.03024)), new(0.0774d, new GammaParticle(53400.0, 0.02322)), new(0.086d, new GammaParticle(93700.0, 0.01323)), new(0.081d, new GammaParticle(181800.0, 0.00682)), new(0.789d, new GammaParticle(367000.0, 0.00338)), new(0.935d, new GammaParticle(608100.0, 0.00204)), new(0.8290000000000001d, new GammaParticle(736400.0, 0.00168)), new(0.968d, new GammaParticle(752100.0, 0.00165)), new(0.145d, new GammaParticle(918100.0, 0.00135)), new(1.1786925167233d, new GammaParticle(12904.0, 0.09608)), new(0.3506112131560017d, new GammaParticle(74815.0, 0.01657)), new(0.5866006577814985d, new GammaParticle(77108.0, 0.01608)), new(0.20093363236026032d, new GammaParticle(87388.0, 0.01419)), new(0.2624193238625d, new GammaParticle(88458.0, 0.01402)), new(0.06148569150223966d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    