using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin129p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin129p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 128.91542d;

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
    