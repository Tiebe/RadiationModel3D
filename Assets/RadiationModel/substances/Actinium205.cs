using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium205";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 205.01515d;

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
    