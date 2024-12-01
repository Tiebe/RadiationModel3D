using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium148";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 147.95838d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium148()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    