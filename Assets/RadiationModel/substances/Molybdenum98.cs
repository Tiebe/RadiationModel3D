using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum98 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum98";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 97.9054d;

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
    