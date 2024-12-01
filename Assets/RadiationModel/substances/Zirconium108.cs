using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium108";
        public override double halfLife { get; } = 0.0774d;
        public override double atomicWeight { get; } = 107.9453d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium108()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    