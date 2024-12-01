using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium154m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 153.93087d;

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
    