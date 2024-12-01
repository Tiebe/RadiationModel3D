using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fluorine17i : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine17i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 17.01411d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.033d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fluorine17()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    