using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Calcium37 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium37";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 36.9859d;

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
    