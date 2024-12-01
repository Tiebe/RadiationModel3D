using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine141 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine141";
        public override double halfLife { get; } = 0.418d;
        public override double atomicWeight { get; } = 140.93567d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon141()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.212d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon141()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    