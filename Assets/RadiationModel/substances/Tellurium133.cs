using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium133";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 132.91096d;

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
    