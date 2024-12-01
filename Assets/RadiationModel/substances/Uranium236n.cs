using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium236n : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium236n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 236.04852d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium236()) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    