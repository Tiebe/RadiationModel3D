using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium153";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 152.94937d;

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
    