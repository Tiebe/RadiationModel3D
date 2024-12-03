using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron61m : RadioactiveSubstance
    {
        public override string name { get; } = "Iron61m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 60.93767d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron61()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    