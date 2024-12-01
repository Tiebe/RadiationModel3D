using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium146n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium146n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 145.96713d;

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
    