using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium115";
        public override double halfLife { get; } = 0.99d;
        public override double atomicWeight { get; } = 114.92031d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium115()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    