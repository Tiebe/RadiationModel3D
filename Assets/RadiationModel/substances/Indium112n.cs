using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium112n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium112n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 111.90592d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium112()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    