using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium135";
        public override double halfLife { get; } = 1440.0d;
        public override double atomicWeight { get; } = 134.91311d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum135()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    