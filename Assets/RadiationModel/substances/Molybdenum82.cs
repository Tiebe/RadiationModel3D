using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum82 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum82";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 81.95666d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium82()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    