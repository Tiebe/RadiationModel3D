using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold174m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold174m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 173.98505d;

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
    