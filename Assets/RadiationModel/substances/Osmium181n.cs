using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium181n : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium181n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 180.95342d;

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
    