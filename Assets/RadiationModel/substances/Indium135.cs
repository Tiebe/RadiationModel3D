using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium135";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 134.94943d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin135()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin135()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    