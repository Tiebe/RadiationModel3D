using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium163";
        public override double halfLife { get; } = 144215151703.88544d;
        public override double atomicWeight { get; } = 162.92874d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium163()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    