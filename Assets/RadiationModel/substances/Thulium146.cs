using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium146";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 145.96666d;

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
    