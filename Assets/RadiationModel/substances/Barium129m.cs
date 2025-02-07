using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium129m";
        public override double halfLife { get; } = 7686.0d;
        public override double atomicWeight { get; } = 128.90869d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon129()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    