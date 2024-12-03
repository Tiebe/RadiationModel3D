using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium62j : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium62j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 61.9448d;

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
    