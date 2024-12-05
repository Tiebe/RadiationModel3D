using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium139";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 138.93537d;

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
    