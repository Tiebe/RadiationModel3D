using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium42r : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium42r";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 41.97204d;

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
    