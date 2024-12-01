using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel68m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel68m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 67.93359d;

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
    