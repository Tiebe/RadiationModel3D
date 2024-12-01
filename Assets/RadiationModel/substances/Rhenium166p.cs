using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium166p : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium166p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 165.96612d;

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
    