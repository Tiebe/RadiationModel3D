using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium135";
        public override double halfLife { get; } = 0.00094d;
        public override double atomicWeight { get; } = 134.96452d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium134()), new(1.0d, new ProtonParticle()) } },
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
    