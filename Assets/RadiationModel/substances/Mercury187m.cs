using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury187m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury187m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 186.96988d;

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
    