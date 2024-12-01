using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Flerovium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium287";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 287.18672d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copernicium283()), new(1.0d, new AlphaParticle(11187002.09)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    