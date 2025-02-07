using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium233";
        public override double halfLife { get; } = 23.0d;
        public override double atomicWeight { get; } = 233.05077d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.8d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium233()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium229()), new(1.0d, new AlphaParticle(8497002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    