using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium234";
        public override double halfLife { get; } = 51.0d;
        public override double atomicWeight { get; } = 234.05016d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium230()), new(1.0d, new AlphaParticle(8387002.09)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium234()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    