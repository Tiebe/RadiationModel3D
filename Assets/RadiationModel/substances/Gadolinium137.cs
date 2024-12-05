using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium137";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 136.94502d;

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
    