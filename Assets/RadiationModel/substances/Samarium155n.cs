using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium155n : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium155n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 154.92522d;

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
    