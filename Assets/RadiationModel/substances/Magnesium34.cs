using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Magnesium34 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium34";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 34.00894d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Aluminum34()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    