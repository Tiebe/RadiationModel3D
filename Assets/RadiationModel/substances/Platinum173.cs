using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum173 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum173";
        public override double halfLife { get; } = 0.382d;
        public override double atomicWeight { get; } = 172.97645d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.86d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium169()), new(1.0d, new AlphaParticle(7380002.09)) } },
            { 0.16d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium173()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    