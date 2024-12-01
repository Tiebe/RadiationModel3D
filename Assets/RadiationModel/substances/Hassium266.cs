using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium266";
        public override double halfLife { get; } = 0.00297d;
        public override double atomicWeight { get; } = 266.13005d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.76d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium262()), new(1.0d, new AlphaParticle(11368002.09)) } },
            { 0.24d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    