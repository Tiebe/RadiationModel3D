using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold192m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold192m";
        public override double halfLife { get; } = 0.029d;
        public override double atomicWeight { get; } = 191.96496d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold192()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    