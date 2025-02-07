using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lithium7i : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium7i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 7.02807d;

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
    