using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper58i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper58i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 57.94475d;

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
    