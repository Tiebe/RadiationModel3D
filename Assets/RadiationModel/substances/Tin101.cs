using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin101 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin101";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 100.93525d;

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
    