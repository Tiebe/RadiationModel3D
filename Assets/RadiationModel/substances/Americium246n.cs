using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium246n : RadioactiveSubstance
    {
        public override string name { get; } = "Americium246n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 246.07192d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    