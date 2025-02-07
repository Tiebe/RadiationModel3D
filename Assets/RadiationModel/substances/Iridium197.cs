using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 196.96966d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum197()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    