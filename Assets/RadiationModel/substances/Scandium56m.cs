using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium56m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium56m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.9726d;

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
    