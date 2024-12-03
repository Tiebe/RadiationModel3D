using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium179m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium179m";
        public override double halfLife { get; } = 0.0031d;
        public override double atomicWeight { get; } = 178.94797d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium179()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    