using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium113m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 112.92298d;

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
    