using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium187";
        public override double halfLife { get; } = 51.0d;
        public override double atomicWeight { get; } = 186.9759d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold187()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold183()), new(1.0d, new AlphaParticle(6343002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    