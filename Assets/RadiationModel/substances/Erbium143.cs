using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium143";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 142.96655d;

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
    