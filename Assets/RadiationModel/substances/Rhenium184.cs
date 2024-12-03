using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium184";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 183.95253d;

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
    