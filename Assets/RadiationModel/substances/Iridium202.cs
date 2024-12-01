using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium202";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 201.98214d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum202()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    