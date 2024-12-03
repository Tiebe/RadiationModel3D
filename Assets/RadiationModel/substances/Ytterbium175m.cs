using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium175m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium175m";
        public override double halfLife { get; } = 0.0682d;
        public override double atomicWeight { get; } = 174.94183d;

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
    