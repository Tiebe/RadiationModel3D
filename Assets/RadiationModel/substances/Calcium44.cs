using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Calcium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium44";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 43.95548d;

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
    