using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium234n : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium234n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 234.0488d;

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
    