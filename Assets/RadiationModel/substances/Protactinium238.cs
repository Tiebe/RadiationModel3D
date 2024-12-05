using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium238";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 238.05464d;

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
    