using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium95";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 94.92489d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium95()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    