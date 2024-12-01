using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel57i : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel57i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 56.94542d;

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
    