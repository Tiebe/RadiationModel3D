using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium262";
        public override double halfLife { get; } = 0.102d;
        public override double atomicWeight { get; } = 262.12265d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium258()), new(1.0d, new AlphaParticle(11337002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    