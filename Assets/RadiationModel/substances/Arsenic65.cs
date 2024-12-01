using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic65 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic65";
        public override double halfLife { get; } = 0.128d;
        public override double atomicWeight { get; } = 64.94961d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium65()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    