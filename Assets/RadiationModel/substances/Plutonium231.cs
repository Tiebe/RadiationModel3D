using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium231";
        public override double halfLife { get; } = 516.0d;
        public override double atomicWeight { get; } = 231.04113d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium231()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium227()), new(1.0d, new AlphaParticle(7861002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    