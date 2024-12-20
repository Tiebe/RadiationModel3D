using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium171";
        public override double halfLife { get; } = 4.1d;
        public override double atomicWeight { get; } = 170.94631d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium171()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    