using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus29i : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus29i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 28.9908d;

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
    