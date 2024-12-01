using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth189m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth189m";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 188.98939d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.83d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium185()), new(1.0d, new AlphaParticle(8474002.09)) } },
            { 0.17d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth189()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    