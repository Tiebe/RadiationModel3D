using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium84";
        public override double halfLife { get; } = 1548.0d;
        public override double atomicWeight { get; } = 83.92333d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium84()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    