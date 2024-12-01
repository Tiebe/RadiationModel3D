using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper65 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper65";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 64.92779d;

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
    