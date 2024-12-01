using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium171";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 170.93633d;

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
    