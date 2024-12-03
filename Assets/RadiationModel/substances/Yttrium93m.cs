using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium93m";
        public override double halfLife { get; } = 0.82d;
        public override double atomicWeight { get; } = 92.91039d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium93()), new(0.5123d, new GammaParticle(168499.0, 0.00736)), new(0.998d, new GammaParticle(590238.0, 0.0021)), new(0.0145921261251d, new GammaParticle(2027.0, 0.61166)), new(0.08031749789526856d, new GammaParticle(14883.0, 0.08331)), new(0.1540124600101027d, new GammaParticle(14958.0, 0.08289)), new(0.038670620469796774d, new GammaParticle(16803.0, 0.07379)), new(0.04400716609462872d, new GammaParticle(16880.0, 0.07345)), new(0.005336545624831954d, new GammaParticle(17011.0, 0.07288)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    