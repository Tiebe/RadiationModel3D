using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium104";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 103.91821d;

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
    