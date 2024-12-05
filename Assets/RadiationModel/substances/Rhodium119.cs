using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium119";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 118.93256d;

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
    