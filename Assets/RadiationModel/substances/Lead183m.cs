using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead183m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead183m";
        public override double halfLife { get; } = 0.415d;
        public override double atomicWeight { get; } = 182.99196d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury179()), new(1.0d, new AlphaParticle(8044002.09)) } },
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
    