using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold186n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold186n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 185.9662d;

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
    