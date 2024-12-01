using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium89";
        public override double halfLife { get; } = 12.8d;
        public override double atomicWeight { get; } = 88.92765d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium89()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    