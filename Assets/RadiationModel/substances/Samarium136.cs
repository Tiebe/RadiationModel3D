using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium136";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 135.92828d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium136()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    