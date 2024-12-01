using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium99";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 98.93411d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.009000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver98()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    