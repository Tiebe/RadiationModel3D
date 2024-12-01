using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nitrogen11m : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen11m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 11.02696d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Carbon10()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    