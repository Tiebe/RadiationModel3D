using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium270";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 270.13337d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium266()), new(1.0d, new AlphaParticle(10087002.09)) } },
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
    