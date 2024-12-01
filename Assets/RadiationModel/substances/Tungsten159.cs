using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten159 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten159";
        public override double halfLife { get; } = 0.0073d;
        public override double atomicWeight { get; } = 158.9727d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium155()), new(1.0d, new AlphaParticle(7477002.09)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium159()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    