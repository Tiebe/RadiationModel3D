using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum201 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum201";
        public override double halfLife { get; } = 147.6d;
        public override double atomicWeight { get; } = 200.97451d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold201()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    