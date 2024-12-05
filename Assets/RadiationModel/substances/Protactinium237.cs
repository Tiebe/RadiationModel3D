using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium237";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 237.05102d;

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
    