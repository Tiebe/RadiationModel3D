using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium105m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 104.90777d;

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
    