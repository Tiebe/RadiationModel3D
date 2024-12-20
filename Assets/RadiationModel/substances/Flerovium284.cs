using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Flerovium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium284";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 284.18119d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new AlphaParticle(260985725974.25)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    