using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc61j : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc61j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 60.95023d;

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
    