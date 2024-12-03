using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium91m";
        public override double halfLife { get; } = 2982.6d;
        public override double atomicWeight { get; } = 90.90789d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium91()), new(0.95d, new GammaParticle(555570.0, 0.00223)), new(0.0015254464735d, new GammaParticle(2027.0, 0.61166)), new(0.008969988015411585d, new GammaParticle(14883.0, 0.08331)), new(0.01720036052811426d, new GammaParticle(14958.0, 0.08289)), new(0.004318797413421928d, new GammaParticle(16803.0, 0.07379)), new(0.004914791456474154d, new GammaParticle(16880.0, 0.07345)), new(0.000595994043052226d, new GammaParticle(17011.0, 0.07288)) } },
            { 0.015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium91()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    