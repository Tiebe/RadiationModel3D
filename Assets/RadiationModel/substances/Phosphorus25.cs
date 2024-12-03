using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus25 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus25";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 25.02167d;

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
    