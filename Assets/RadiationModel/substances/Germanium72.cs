using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium72 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium72";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 71.92208d;

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
    