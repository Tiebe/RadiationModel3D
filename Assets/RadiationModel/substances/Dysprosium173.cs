using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium173";
        public override double halfLife { get; } = 1.43d;
        public override double atomicWeight { get; } = 172.95304d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium173()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    