using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium177m";
        public override double halfLife { get; } = 95.0d;
        public override double atomicWeight { get; } = 176.94904d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium177()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    