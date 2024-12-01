using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium160";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 159.92706d;

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
    