using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium13p : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium13p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 13.03775d;

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
    