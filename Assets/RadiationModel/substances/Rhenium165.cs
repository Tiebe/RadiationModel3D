using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium165";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 164.96709d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.86d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum165()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum161()), new(1.0d, new AlphaParticle(6717002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    