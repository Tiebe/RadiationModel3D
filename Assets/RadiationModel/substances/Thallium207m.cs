using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium207m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium207m";
        public override double halfLife { get; } = 1.33d;
        public override double atomicWeight { get; } = 206.97887d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium207()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    