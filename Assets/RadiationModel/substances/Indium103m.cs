using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium103m";
        public override double halfLife { get; } = 34.0d;
        public override double atomicWeight { get; } = 102.92056d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.67d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver103()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.33d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium103()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    