using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium138";
        public override double halfLife { get; } = 12.1d;
        public override double atomicWeight { get; } = 137.93371d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium138()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    