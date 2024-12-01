using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon30 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon30";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 30.02369d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur28()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    