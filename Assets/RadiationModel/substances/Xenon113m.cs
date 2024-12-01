using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon113m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon113m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 112.93365d;

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
    