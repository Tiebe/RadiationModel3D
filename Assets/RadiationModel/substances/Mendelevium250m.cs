using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium250m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 250.08429d;

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
    