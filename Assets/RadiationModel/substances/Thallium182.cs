using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium182";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 181.98569d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.975d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold182()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold178()), new(1.0d, new AlphaParticle(7573002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    