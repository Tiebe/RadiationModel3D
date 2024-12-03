using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper57i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper57i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 56.9549d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel56()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    