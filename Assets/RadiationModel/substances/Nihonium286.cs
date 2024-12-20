using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nihonium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium286";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 286.18246d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Roentgenium282()), new(1.0d, new AlphaParticle(10817002.09)) } },
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
    