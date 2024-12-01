using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold178q : RadioactiveSubstance
    {
        public override string name { get; } = "Gold178q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 177.97645d;

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
    