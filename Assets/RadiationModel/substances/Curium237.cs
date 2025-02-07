using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium237";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.05287d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium233()), new(1.0d, new AlphaParticle(7797002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    