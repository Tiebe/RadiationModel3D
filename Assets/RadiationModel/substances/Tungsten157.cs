using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten157 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten157";
        public override double halfLife { get; } = 0.275d;
        public override double atomicWeight { get; } = 156.97886d;

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
    