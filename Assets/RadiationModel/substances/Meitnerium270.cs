using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Meitnerium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium270";
        public override double halfLife { get; } = 0.48d;
        public override double atomicWeight { get; } = 270.14032d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bohrium266()), new(1.0d, new AlphaParticle(11207002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    