using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium243";
        public override double halfLife { get; } = 0.231d;
        public override double atomicWeight { get; } = 243.07442d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium239()), new(1.0d, new AlphaParticle(9717002.09)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium243()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    