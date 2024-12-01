using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium225";
        public override double halfLife { get; } = 237.0d;
        public override double atomicWeight { get; } = 225.02557d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium225()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    