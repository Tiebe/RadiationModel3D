using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium273";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 273.14146d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium269()), new(1.0d, new AlphaParticle(10677002.09)) } },
            { 0.125d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    