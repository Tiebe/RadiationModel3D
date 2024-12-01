using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium194";
        public override double halfLife { get; } = 0.392d;
        public override double atomicWeight { get; } = 193.98819d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.93d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead190()), new(1.0d, new AlphaParticle(8009002.09)) } },
            { 0.07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead194()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    