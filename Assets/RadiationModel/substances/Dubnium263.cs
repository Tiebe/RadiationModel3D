using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium263";
        public override double halfLife { get; } = 27.0d;
        public override double atomicWeight { get; } = 263.11499d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.57d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.43d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium259()), new(1.0d, new AlphaParticle(9857002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    