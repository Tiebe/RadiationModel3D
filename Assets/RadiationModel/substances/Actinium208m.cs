using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium208m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium208m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 208.01209d;

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
    