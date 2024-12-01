using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium275";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 275.14653d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium271()), new(1.0d, new AlphaParticle(10467002.09)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    