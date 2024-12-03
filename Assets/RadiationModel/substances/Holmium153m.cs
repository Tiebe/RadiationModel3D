using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium153m";
        public override double halfLife { get; } = 558.0d;
        public override double atomicWeight { get; } = 152.93028d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9982d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium153()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0018d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium149()), new(1.0d, new AlphaParticle(5143002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    