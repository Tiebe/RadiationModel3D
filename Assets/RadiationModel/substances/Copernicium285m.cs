using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copernicium285m : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium285m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 285.1778d;

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
    