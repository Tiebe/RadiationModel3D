using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium206";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 205.99866d;

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
    