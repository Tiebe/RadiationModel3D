using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead178 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead178";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 178.00384d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury174()), new(1.0d, new AlphaParticle(8811002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    