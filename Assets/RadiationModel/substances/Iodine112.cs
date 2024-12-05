using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine112 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine112";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 111.928d;

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
    