using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nitrogen15i : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen15i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 15.01258d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 5.2300000000000004e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nitrogen15()) } },
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
    