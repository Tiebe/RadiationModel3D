using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium218";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 218.02002d;

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
    