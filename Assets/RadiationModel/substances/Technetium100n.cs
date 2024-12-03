using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium100n : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium100n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 99.90791d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium100()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    