using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium265";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 265.12979d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium261()), new(1.0d, new AlphaParticle(11492002.09)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    