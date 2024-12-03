using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Calcium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium53";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 52.96845d;

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
    