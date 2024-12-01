using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium262p : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium262p";
        public override double halfLife { get; } = 35.0d;
        public override double atomicWeight { get; } = 262.11412d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.67d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium258()), new(1.0d, new AlphaParticle(10117002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    