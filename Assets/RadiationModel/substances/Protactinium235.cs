using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium235";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 235.0454d;

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
    