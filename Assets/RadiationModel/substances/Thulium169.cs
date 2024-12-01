using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium169";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 168.93422d;

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
    