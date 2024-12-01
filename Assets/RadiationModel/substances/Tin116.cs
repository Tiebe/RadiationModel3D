using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin116 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin116";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 115.90174d;

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
    