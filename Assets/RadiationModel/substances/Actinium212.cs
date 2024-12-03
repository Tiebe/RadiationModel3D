using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium212";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 212.00784d;

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
    