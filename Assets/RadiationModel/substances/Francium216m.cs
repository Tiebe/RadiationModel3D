using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium216m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 216.00342d;

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
    