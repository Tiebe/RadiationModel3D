using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc81 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc81";
        public override double halfLife { get; } = 0.32d;
        public override double atomicWeight { get; } = 80.9504d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium81()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.075d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium81()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    