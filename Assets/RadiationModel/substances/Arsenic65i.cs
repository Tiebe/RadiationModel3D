using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic65i : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic65i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 64.95335d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium64()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    