using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver107 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver107";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 106.90509d;

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
    