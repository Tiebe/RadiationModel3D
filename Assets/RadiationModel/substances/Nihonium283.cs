using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nihonium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium283";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 283.17666d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Roentgenium279()), new(1.0d, new AlphaParticle(11437002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    