using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bohrium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium264";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 264.12449d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dubnium260()), new(1.0d, new AlphaParticle(10887002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    