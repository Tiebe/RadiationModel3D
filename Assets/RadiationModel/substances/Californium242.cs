using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium242";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 242.06375d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.61d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium238()), new(1.0d, new AlphaParticle(8539002.09)) } },
            { 0.39d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium242()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.00014000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    