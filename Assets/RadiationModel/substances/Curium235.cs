using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium235";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 235.05154d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.011000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium231()), new(1.0d, new AlphaParticle(8298002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    