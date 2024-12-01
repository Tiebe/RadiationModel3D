using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten162 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten162";
        public override double halfLife { get; } = 1.19d;
        public override double atomicWeight { get; } = 161.9635d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5479999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium162()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.452d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium158()), new(1.0d, new AlphaParticle(6700002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    