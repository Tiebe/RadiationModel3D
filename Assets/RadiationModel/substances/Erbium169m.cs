using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium169m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 168.9347d;

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
    