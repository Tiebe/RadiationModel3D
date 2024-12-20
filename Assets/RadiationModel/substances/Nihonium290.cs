using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nihonium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium290";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 290.19143d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Roentgenium286()), new(1.0d, new AlphaParticle(10407002.09)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    