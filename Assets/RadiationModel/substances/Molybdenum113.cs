using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum113 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum113";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 112.94348d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium113()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    