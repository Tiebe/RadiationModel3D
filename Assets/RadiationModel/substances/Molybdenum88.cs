using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum88 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum88";
        public override double halfLife { get; } = 480.0d;
        public override double atomicWeight { get; } = 87.92197d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium88()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    