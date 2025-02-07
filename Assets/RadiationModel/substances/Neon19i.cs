using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neon19i : RadioactiveSubstance
    {
        public override string name { get; } = "Neon19i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 19.00993d;

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
    