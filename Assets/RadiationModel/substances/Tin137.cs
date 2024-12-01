using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin137 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin137";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 136.94616d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony137()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.58d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony137()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    