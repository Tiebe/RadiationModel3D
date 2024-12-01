using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium73m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium73m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 72.95107d;

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
    