using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium158";
        public override double halfLife { get; } = 678.0d;
        public override double atomicWeight { get; } = 157.92895d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium158()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    