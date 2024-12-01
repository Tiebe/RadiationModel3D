using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine109 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine109";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 108.93809d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9998600000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium108()), new(1.0d, new ProtonParticle()) } },
            { 0.00014000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony105()), new(1.0d, new AlphaParticle(4939002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    