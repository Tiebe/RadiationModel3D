using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium166m";
        public override double halfLife { get; } = 0.0151d;
        public override double atomicWeight { get; } = 165.9859d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.982d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium162()), new(1.0d, new AlphaParticle(7917002.09)) } },
            { 0.018000000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium165()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    