using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium175";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 174.95138d;

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
    