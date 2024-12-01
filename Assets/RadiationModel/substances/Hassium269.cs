using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium269";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 269.13365d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium265()), new(1.0d, new AlphaParticle(10297002.09)) } },
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
    