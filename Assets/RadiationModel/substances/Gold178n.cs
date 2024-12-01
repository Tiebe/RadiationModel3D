using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold178n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold178n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 177.97626d;

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
    