using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium228";
        public override double halfLife { get; } = 61.4d;
        public override double atomicWeight { get; } = 228.03632d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium228()) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium224()), new(1.0d, new AlphaParticle(8565002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    