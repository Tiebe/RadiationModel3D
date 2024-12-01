using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Boron15 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron15";
        public override double halfLife { get; } = 0.00993d;
        public override double atomicWeight { get; } = 15.03109d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Carbon15()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.9968d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Carbon15()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    