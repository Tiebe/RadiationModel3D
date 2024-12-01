using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium86";
        public override double halfLife { get; } = 0.226d;
        public override double atomicWeight { get; } = 85.94697d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic86()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.45d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic86()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    