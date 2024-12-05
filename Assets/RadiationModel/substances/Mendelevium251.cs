using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium251";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 251.08477d;

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
    