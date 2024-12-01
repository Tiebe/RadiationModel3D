using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead187 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead187";
        public override double halfLife { get; } = 15.2d;
        public override double atomicWeight { get; } = 186.98391d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.905d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury187()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.095d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury183()), new(1.0d, new AlphaParticle(7415002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    