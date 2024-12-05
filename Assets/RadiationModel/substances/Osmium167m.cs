using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium167m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 166.97201d;

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
    