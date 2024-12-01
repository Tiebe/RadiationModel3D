using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium143m";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 142.93514d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium143()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    