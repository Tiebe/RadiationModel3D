using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Seaborgium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium269";
        public override double halfLife { get; } = 130.0d;
        public override double atomicWeight { get; } = 269.12849d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium265()), new(1.0d, new AlphaParticle(9597002.09)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    