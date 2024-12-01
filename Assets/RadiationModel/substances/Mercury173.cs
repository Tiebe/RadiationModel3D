using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury173 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury173";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 172.99714d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum169()), new(1.0d, new AlphaParticle(8397002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    