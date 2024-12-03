using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine138m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine138m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 137.9228d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine138()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    