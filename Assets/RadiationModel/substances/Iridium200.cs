using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium200";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 199.97684d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum200()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    