using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium230";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 230.04239d;

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
    