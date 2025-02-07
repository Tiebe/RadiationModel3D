using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead195 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead195";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 194.97452d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury195()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    