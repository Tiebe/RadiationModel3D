using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium97n : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium97n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 96.92727d;

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
    