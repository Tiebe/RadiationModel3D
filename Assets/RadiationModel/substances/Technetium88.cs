using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium88";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 87.93379d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    