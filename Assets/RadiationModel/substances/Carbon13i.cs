using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Carbon13i : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon13i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 13.01957d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.008199999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Carbon13()) } },
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
    