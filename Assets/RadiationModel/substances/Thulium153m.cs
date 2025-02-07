using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium153m";
        public override double halfLife { get; } = 2.5d;
        public override double atomicWeight { get; } = 152.9421d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.92d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium149()), new(1.0d, new AlphaParticle(6313002.09)) } },
            { 0.08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium153()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    