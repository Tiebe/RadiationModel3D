using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium138";
        public override double halfLife { get; } = 1.388504742882048e+24d;
        public override double atomicWeight { get; } = 137.90599d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium138()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    