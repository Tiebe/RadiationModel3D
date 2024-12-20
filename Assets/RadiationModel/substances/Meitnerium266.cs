using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Meitnerium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium266";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 266.13706d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bohrium262()), new(1.0d, new AlphaParticle(12017002.09)) } },
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
    