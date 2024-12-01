using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium147m";
        public override double halfLife { get; } = 0.00036d;
        public override double atomicWeight { get; } = 146.96145d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium146()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    