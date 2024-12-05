using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine23 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine23";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.00353d;

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
    