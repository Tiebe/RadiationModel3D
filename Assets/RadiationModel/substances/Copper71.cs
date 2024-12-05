using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper71 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper71";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 70.93268d;

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
    