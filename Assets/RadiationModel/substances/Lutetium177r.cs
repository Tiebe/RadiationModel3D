using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium177r : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177r";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 176.94755d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium177()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    