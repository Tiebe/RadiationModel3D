using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium45i : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium45i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 44.97092d;

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
    