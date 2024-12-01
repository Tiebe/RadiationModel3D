using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead186 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead186";
        public override double halfLife { get; } = 4.81d;
        public override double atomicWeight { get; } = 185.98424d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury186()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury182()), new(1.0d, new AlphaParticle(7493002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    