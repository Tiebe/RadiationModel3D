using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon113 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon113";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 112.93322d;

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
    