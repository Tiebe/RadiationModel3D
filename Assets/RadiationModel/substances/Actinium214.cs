using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium214";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 214.00691d;

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
    