using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197m";
        public override double halfLife { get; } = 534.0d;
        public override double atomicWeight { get; } = 196.96978d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9975d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum197()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0025d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium197()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    