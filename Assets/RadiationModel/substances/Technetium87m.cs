using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium87m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 86.93807d;

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
    