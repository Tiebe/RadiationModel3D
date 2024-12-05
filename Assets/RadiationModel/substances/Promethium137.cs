using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium137";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 136.92048d;

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
    