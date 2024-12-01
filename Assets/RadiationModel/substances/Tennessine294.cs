using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tennessine294 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine294";
        public override double halfLife { get; } = 0.051d;
        public override double atomicWeight { get; } = 294.21084d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Moscovium290()), new(1.0d, new AlphaParticle(12207002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    