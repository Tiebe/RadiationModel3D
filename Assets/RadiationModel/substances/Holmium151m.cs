using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151m";
        public override double halfLife { get; } = 47.2d;
        public override double atomicWeight { get; } = 150.93174d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.8d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium147()), new(1.0d, new AlphaParticle(5758002.09)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium151()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    