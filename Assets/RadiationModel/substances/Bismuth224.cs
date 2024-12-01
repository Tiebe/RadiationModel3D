using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth224 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth224";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 224.0398d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium224()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    