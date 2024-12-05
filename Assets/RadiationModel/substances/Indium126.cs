using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium126";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 125.91647d;

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
    