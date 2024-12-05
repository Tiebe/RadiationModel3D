using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium142";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 141.96001d;

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
    