using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium105";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 104.92494d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum105()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.017d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum105()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    