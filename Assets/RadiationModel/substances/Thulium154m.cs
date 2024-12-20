using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium154m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 153.94165d;

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
    