using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine120m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine120m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 119.91017d;

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
    