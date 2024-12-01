using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium150m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 149.97343d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium149()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    