using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel69m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel69m";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 68.93595d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copper69()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.74d, new GammaParticle(1297900.0, 0.00096)) } },
            { 0.0001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel69()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    