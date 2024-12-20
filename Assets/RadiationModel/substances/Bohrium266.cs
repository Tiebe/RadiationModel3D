using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium266";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 266.12679d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium262()), new(1.0d, new AlphaParticle(10447002.09)) } },
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
    