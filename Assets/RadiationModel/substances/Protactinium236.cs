using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium236";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 236.04867d;

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
    