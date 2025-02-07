using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium73m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium73m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 72.92347d;

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
    