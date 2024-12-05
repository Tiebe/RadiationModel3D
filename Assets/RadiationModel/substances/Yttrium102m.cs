using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium102m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 101.93444d;

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
    