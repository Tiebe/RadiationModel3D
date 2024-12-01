using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold206 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold206";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 205.98477d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury206()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    