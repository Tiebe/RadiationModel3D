using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium175";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 174.94384d;

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
    