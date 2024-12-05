using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese61 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese61";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 60.94445d;

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
    