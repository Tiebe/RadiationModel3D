using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium232";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 232.04011d;

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
    