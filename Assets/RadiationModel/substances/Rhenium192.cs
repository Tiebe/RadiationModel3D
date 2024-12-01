using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium192";
        public override double halfLife { get; } = 16.0d;
        public override double atomicWeight { get; } = 191.96609d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium192()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    