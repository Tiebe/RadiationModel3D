using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium104";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 103.92291d;

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
    