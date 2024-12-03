using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine70 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine70";
        public override double halfLife { get; } = 0.0791d;
        public override double atomicWeight { get; } = 69.94479d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic70()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    