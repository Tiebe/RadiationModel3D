using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hassium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium267";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 267.13168d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium263()), new(1.0d, new AlphaParticle(11057002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    